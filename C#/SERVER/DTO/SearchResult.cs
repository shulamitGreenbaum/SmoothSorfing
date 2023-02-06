using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class SearchResult
    {
        public List<int> KeyWordsIds { get; set; } = new List<int>();
        public List<ActionDTO> SortedPosibleActions { get; set; } = new List<ActionDTO>();

       
      
    }
}
