using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public  class SearchBL
    {
      public static void SaveSearch(tbKWord s )
        {
            using (smoothsurfingEntities db = new smoothsurfingEntities())
            {
                db.tbKWord.Add(s);
                db.SaveChanges();


            }

        }
    }
}
