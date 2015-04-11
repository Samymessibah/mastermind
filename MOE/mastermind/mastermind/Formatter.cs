using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class Formatter
    {
        public virtual String formater(int[] s)
        {
            String st = "";

            for (int i = 0; i < s.Length; i++)
            {
                st = st + " " + s[i];
            }
            return st;
        }
    }
}