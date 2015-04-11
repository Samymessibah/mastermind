using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class CombinaisonContainer
    {
        List<Combinaison> combinaison = new List<Combinaison>();

        public void ajoutcombinaison(Combinaison c)
        {
            combinaison.Add(c);
        }

    }
}
