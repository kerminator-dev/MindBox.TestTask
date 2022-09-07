using MathLib.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace MathLibTest
{
    [TestClass]
    public class PolygonUnitTest
    {
        [TestMethod]
        public void PolygonWith5Points()
        {
            Shape polygon = new Polygon
            (
                new Point(0, 0),
                new Point(1, 0),
                new Point(1, 1),
                new Point(0, 1),
                new Point(-1, 0)
            );

            double expected = 1.5;
            double actual = polygon.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PolygonWithZeroPoints()
        {
            Shape polygon = new Polygon
            (
                new Point(0, 0),
                new Point(0, 0),
                new Point(0, 0)
            );

            double expected = 0;
            double actual = polygon.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PolygonWithNegativePoints()
        {
            Shape polygon = new Polygon
            (
                new Point(-1, -1),
                new Point(0, -1),
                new Point(0, 0),
                new Point(-1, 0),
                new Point(-2, -1)
            );

            double expected = 1;
            double actual = polygon.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PolygonWithTwoPoints()
        {
            Shape polygon = new Polygon
            (
                new Point(-1, -1),
                new Point(0, -1)
            );

            double expected = 1;
            double actual = polygon.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }
}
