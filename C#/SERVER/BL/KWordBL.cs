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
                // return db.action.Where(a => a.actionword.Any()).tolist().OrderBy();
                return db.action.ToList().OrderBy(a => a.count_fidback).ToList();
            }
        }

        public static SearchResult Search(string searchText)
        {

            SearchResult result = new SearchResult();
            var allWords = GetAllKeyWords();
            var searchWords = searchText.Split(' ').ToList();
            var searchKeyWords = allWords.Where(w => searchWords.Any(s => s == w.name));
            result.KeyWordsIds = searchKeyWords.Select(k => int.Parse(k.KeyWordId)).ToList();
            //todo Change senid to macro FK
            //convert with convert func
            result.SortedPosibleActions = GetPossibleActionsByKeyWords(result.KeyWordsIds);
            return searchKeyWords.SelectMany(sw => sw.action).Select(w => w.macro.ToString()).ToList();

        }


    }

}
