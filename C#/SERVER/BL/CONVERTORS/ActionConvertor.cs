using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.CONVERTORS
{
  public static class ActionConvertor
    {
        public static ActionDTO ConvertActionToDAL(action action) //ConvertActionToDAL this was DTO but we changed it because it makes more sense
        {
            return new ActionDTO()
            {
                id = action.id,
                name = action.name,
                id_volanteer = action.id_volanteer,
                macro = action.macro,
                count_fidback = action.count_fidback,

            };  
           
        }

   
        public static IEnumerable<ActionDTO> ConvertActionsToDAL(IEnumerable<action> actions)
        {
            return actions.Select(a => ConvertActionToDAL(a));
           
        }
    }
}
