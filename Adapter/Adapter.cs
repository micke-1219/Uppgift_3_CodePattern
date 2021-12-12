using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class Adapter
    {
        public int Convert(string s)
        {
            int i = Int32.Parse(s);
            return i;
        }
    }
}
