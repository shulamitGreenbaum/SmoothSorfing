using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ActionWordDTO
    {
        public string word_id { get; set; }
        public int action_id { get; set; }
        public Nullable<int> usingWordCounter { get; set; }

       
    }
}
