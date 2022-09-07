using MathLib.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathLibTest
{
    [TestClass]
    public class CircleUnitTest
    {
        [TestMethod]
        public void PositiveRadiusParam()
        {
            Shape circle = new Circle(1.5);

            double expectedArea = 7.0685834705770345;
            double actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void ZeroRadiusParam()
        {
            Shape circle = new Circle(0);

            double expectedArea = 0;
            double actualArea = circle.GetArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeRadiusParam()
        {
            Shape circle = new Circle(-2);
        }
    }
}