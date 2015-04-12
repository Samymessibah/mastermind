
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mastermind
{
    [TestClass]
 public   class TestUnitaire
    {
            [TestMethod]
            public void TestFormater()
            { 
                int [] tab ={1,2,3,5};
                Formatter r = new Formatter();
              //  Console.WriteLine(r.formater(tab));
                //Console.Read();
                Assert.AreEqual(" 1 2 3 5", r.formater(tab));
            
        }
    }
}
