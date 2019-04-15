using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rdf.Controllers;

namespace Rdf.Tests.Controllers
{
    [TestClass]
    public class TriangleTypeControllerTest
    {
        [TestMethod]
        public void TriTypeGet()
        {
            var controller = new TriangleTypeController();
            Equals(controller.Get(0, 1, 2), "Error");
            Equals(controller.Get(1, 1, 2), "Error");
            Equals(controller.Get(3, 1, 2), "Error");
            Equals(controller.Get(2, 2, 2), "Equilateral");
            Equals(controller.Get(2, 2, 3), "Isosceles");
            Equals(controller.Get(3, 4, 5), "Scalene");
        }
    }
}
