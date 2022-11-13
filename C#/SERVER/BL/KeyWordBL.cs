
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BL
{
    public class KeyWordBL
    {
        public static void AddKeyWord(KeyWordDTO KeyWord)
        {
            using (smoothsurfingEntities db = new smoothsurfingEntities())
            {
                db.tbKeyWord.Add(CONVERTORS.TdKeyWordConvertor.ConvertTdKeyWordToDAL(KeyWord));
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

        public static SearchResult Search(string searchText)
        {
            
            SearchResult result = new SearchResult();
            var allWords = GetAllKeyWords();
            var searchWords = searchText.Split(' ').ToList();
            var searchKeyWords = allWords.Where(w => searchWords.Any(s => s == w.name));
            result.KeyWordsIds = searchKeyWords.Select(k =>int.Parse(k.KeyWordId)).ToList();
            //todo Change senid to macro FK
            result.SortedPosibleActions = GetPossibleActionsByKeyWords(result.KeyWordsIds);
            return searchKeyWords.SelectMany(sw => sw.action).Select(w => w.macro.ToString()).ToList();

        }

        private static List<Acacttion> GetPossibleActionsByKeyWords(List<int> keyWordsIds)
        {
            using(smoothsurfingEntities db=new smoothsurfingEntities())
            {
                // return db.action.Where(a => a.actionword.Any()).tolist().OrderBy();
                return db.action.ToList().OrderBy(a=>a.count_fidback).ToList();
            }
        }
    }
}
