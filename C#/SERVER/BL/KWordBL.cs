using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BL.CONVERTORS;

namespace BL
{

    public class KWordBL
    {
        public static void AddKWord(KWordDTO kWord)
        {
            using (smoothsurfingEntities db = new smoothsurfingEntities())
            {
                db.tbKWord.Add(CONVERTORS.TbKWordConvertor.ConvertKWordToDAL(kWord));
                db.SaveChanges();
            }
        }
        public static List<tbKWord> GetAllKeyWords()
        {
            using (smoothsurfingEntities db = new smoothsurfingEntities())
            {
                return db.tbKWord.Include(k => k.tbActionWord).ToList();
            }
        }

        private static List<DAL.action> GetPossibleActionsByKeyWords(List<int> keyWordsIds)
        {
            using (smoothsurfingEntities db = new smoothsurfingEntities())
            {
                //todo Should be int and not string in SQL
             //עוברים על טבלת קשר של מילות מפתח לפעולות בוחרים רק את המילים שהמשתמש חיפש ומקבצים לפי פעולה 
                var groupbyAction = db.tbActionWord.Where(a => keyWordsIds.Any(kw => kw == int.Parse(a.word_id)))
                    .GroupBy(a => a.action).ToDictionary(k=>k.Key,v=>v.ToList().Sum(k=>k.usingWordCounter)+v.ToList().Count()*10);//we must check to see which number will govr exact results
                Dictionary<action, int> scoredActions = new Dictionary<action, int>();

                var sortedDict = from entry in groupbyAction orderby entry.Value ascending select entry;
                return sortedDict.Select(k => k.Key).ToList();



            }
        }

        public static SearchResult Search(string searchText)
        {// User types/records his search and we split the sentance and look for key words.

            SearchResult result = new SearchResult();
            var allWords = GetAllKeyWords();
            var searchWords = searchText.Split(' ').ToList();
            var searchKeyWords = allWords.Where(w => searchWords.Any(s => s == w.name));
            result.KeyWordsIds = searchKeyWords.Select(k => int.Parse(k.KeyWordId)).ToList();
            //todo Change senid to macro FK
            //convert with convert func
            result.SortedPosibleActions = ActionConvertor.ConvertActionsToDAL(GetPossibleActionsByKeyWords(result.KeyWordsIds)).ToList();
            return result;
        }


    }

}
