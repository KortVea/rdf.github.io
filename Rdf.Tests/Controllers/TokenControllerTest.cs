using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rdf.Controllers;

namespace Rdf.Tests.Controllers
{
    [TestClass]
    public class TokenControllerTest
    {
        [TestMethod]
        public void TokenGet()
        {
            var controller = new TokenController();
            StringAssert.Equals(controller.Get(), "26f9f0e3-22f8-43a3-8895-f4a1781aac49");
        }
    }
}
