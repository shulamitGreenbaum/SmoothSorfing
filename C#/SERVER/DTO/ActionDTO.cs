using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class ActionDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> id_volanteer { get; set; }
        public Nullable<int> macro { get; set; }
        public Nullable<int> count_fidback { get; set; }

    }
}
