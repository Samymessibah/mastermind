﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class Displayer
    {

            public virtual void Show(String s)
            {
                Console.WriteLine(s);
            }
            public virtual void Clear()
            {
                Console.Clear();
            }
     }
    
}
