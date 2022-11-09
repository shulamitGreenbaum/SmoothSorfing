using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class KWordBL
    {
        public static void AddKWord(KWordDTO kWord)
        {
            using (smoothsurfingEntities db = new smoothsurfingEntities())
            {
                db.tbKWord.Add(CONVERTORS.TbKWordConvertor.ConvertKWordToDAL(kWord));
                db.SaveChanges();
            }
        }
    }

}
