using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rdf.Controllers;

namespace Rdf.Tests.Controllers
{
    [TestClass]
    public class FibonacciControllerTest
    {
        [TestMethod]
        public void FibGet()
        {
            FibonacciController controller = new FibonacciController();
            var expectedValue = new long[16] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 };
            var result = new long[16];
            for (int i = 0; i < 16; i++)
            {
                result[i] = controller.Get(i);
            }
            CollectionAssert.AreEqual(expectedValue, result);
        }

        

    }
}
