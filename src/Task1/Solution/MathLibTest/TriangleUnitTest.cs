using MathLib.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathLibTest
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void PositiveSideParams()
        {
            Shape triangle = new Triangle(3, 4, 2);

            double expectedArea = 2.904737;
            double actualArea = triangle.GetArea();

            Assert.AreEqual(expectedArea, actualArea, 0.000001);
        }

        [TestMethod]
        public void PositiveSideParamsWithPoint()
        {
            Shape triangle = new Triangle(3.3, 1.4, 4.2);

            double expectedArea = 1.975372;
            double actualArea = triangle.GetArea();

            Assert.AreEqual(expectedArea, actualArea, 0.000001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeSideParam()
        {
            Shape triangle = new Triangle(1, -1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeSideParams()
        {
            Shape triangle = new Triangle(-1, -1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BigSideParam()
        {
            Shape triangle = new Triangle(1, 90, 2);
        }

        [TestMethod]
        public void IsRectangularTriangle()
        {
            var triangle = new Triangle(3, 4, 5);

            bool expected = true;
            bool actual = triangle.IsRectangular();

            Assert.AreEqual(expected, actual);
        }
    }
}

