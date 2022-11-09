using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTORS
{
   public static class TdKeyWordConvertor
    {
        public static  tbKeyWord ConvertTdKeyWordToDAL(KeyWordDTO tbKeyWord)
        {
            return new tbKeyWord
            {
               word_id = tbKeyWord.word_id,
               sen_id = tbKeyWord.sen_id
            };
        }
    }
}
