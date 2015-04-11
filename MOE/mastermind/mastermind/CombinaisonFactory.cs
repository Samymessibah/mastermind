using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class CombinaisonFactory
    {
        public Combinaison create(int a,int b, int c, int d){
            int[] tab = { a, b, c, d };
            return new Combinaison(tab);
        }
    }
}
