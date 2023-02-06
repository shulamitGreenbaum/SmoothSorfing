using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.CONVERTORS
{
    public static class TbActionWordConvertor
    {
        public static ActionWordDTO ConvertActionWordToDAL(tbActionWord actionWord)
        {
            return new ActionWordDTO
            {
                word_id = actionWord.word_id,
                action_id = actionWord.action_id,
                usingWordCounter = actionWord.usingWordCounter
            };
        }

        public static IEnumerable<ActionWordDTO> ConvertActionWordsToDAL(IEnumerable<tbActionWord> actionWords)
        {
            return actionWords.Select(a => ConvertActionWordToDAL(a));

        }
    }
}