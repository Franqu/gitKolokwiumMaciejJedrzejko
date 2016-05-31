using Microsoft.VisualStudio.TestTools.UnitTesting;
using kolokwiumMaciejJedrzejko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumMaciejJedrzejko.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void ZadanieTest()
        {
            

            if ( N = 26 && P = 1 && Q = 1 )
            {
               
                Assert.AreEqual(M, 10);
            
            }
            if(N = 26 && P = 4 && Q = 10)
            {
                Assert.AreEqual(M, 4);
            }

            if (N = 26 && P = 16 && Q = 20)
            {
                Assert.AreEqual(M, 0);
            }

            if (N = 14 && P = 4 && Q = 10)
            {
                Assert.AreEqual(M, 4);
            }
            if (N = 21 && P = 9 && Q = 14)
            {
                Assert.AreEqual(M, 3);
            }
            Assert.Fail("b³¹d");
        }
    }
}