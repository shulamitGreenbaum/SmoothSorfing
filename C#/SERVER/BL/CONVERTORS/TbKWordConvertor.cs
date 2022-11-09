using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTORS
{
    class TbKWordConvertor
    {
        public static tbKWord ConvertKWordToDAL(KWordDTO kWord)
        {
            return new tbKWord
            {
                KeyWordId = kWord.KeyWordId,
                name = kWord.name,
            };
        }
        
    }
}
