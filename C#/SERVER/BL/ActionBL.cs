using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class ActionBL
    {
        public static action GetMacro(int id)
        {
            using (smoothsurfingEntities db = new smoothsurfingEntities())
            {
                action action = db.action.Where(m => m.id ==id ).FirstOrDefault();

                if (action == null)
                {
                    return null;
                }

                return action;

            }

        }
        public static void AddCountFidback(int id)
        {
            using (smoothsurfingEntities db = new smoothsurfingEntities())
            {
                action action = db.action.Where(m => m.id == id).FirstOrDefault();
                action.count_fidback++; //counts the amount of videos watched by users

            }
            }



            }

        }
    
}
