using System;
using System.Collections.Generic;
using System.Text;

namespace CL_Shop.IdGenerator
{
    public class IndexPair
    {
        public IndexPair(string type, int index)
        {
            this.type = type;
            this.index = index;
        }

        public string type { get; set; }
        public int index { get; set; }
    }
}
