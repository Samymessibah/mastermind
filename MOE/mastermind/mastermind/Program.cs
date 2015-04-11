using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = { 1, 2 };
            ReaderCombinaison r = new ReaderCombinaison();
            Formatter f =  new Formatter();
            Displayer d = new Displayer();
            string s;

            Console.Write("");
            r.Read();
            s = f.formater(i);
            d.Show(s);
            
        }
    }
}
