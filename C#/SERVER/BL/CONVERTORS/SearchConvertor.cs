using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.CONVERTORS
{
    public static class SearchConvertor
    {
        public static searchDTO ConvertSearchToDAL(search search)
        {
            return new searchDTO
            {
                id = search.id,
                idAction = search.idAction,
                dit = search.dit
            };

        }
        public static IEnumerable<searchDTO> ConvertSearchsToDTO(IEnumerable<search> searchs)
        {
            return searchs.Select(a => ConvertSearchToDAL(a));

        }
    }
}
