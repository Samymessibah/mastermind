using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class ReaderCombinaison
    {
        public virtual int Read()
        {
            int num = 0;
            string UserEntry = "";
            bool IsOk = false;

            UserEntry = Console.ReadLine();
            IsOk = int.TryParse(UserEntry, out num);
            if (IsOk == true) {
                return num;}
              
            return -1;
        }
    }
}
