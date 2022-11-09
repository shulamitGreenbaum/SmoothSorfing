
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


                return db.tbKWord.Include(k => k.action).ToList();

            }

        }

        public static List<action> Search(string searchText)
        {
            var allWords = GetAllKeyWords();
            var searchWords = searchText.Split(' ').ToList();
            var searchKeyWords = allWords.Where(w => searchWords.Any(s => s == w.name));
            //todo Change senid to macro FK
            return searchKeyWords.SelectMany(sw => sw.action).Select(w => w.macro.ToString()).ToList();

        }
    }
}
