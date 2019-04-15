using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rdf.Controllers;

namespace Rdf.Tests.Controllers
{
    [TestClass]
    public class ReverseWordsControllerTest
    {
        [TestMethod]
        public void RevGet()
        {
            var controller = new ReverseWordsController();
            StringAssert.Equals(controller.Get("abcdefg"), "gfedcba");
        }
    }
}
