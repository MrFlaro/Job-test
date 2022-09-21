using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeMath.Lib.Primitives;
using System;

namespace ShapeMath.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleRadiusValidityTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-5));
        }

        [TestMethod]
        public void TriangleSideValidityTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-5, 5, 5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(5, -5, 5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(5, 5, -5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-5, -5, -5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, 0, 0));
        }

        [TestMethod]
        public void CircleSqrTest()
        {
            var circle = new Circle(50);
            Assert.AreEqual(7853.981633974483, circle.AreaSquare);
        }

        [TestMethod]
        public void TriangeSqrTest()
        {
            var triangle = new Triangle(3,4,5);
            Assert.AreEqual(6, triangle.AreaSquare);
        }

        [TestMethod]
        public void TriangleRightAngleTest()
        {
            var triangle = new Triangle(5,4,3);
            Assert.IsTrue(triangle.IsRightAngled);
        }

        [TestMethod]
        public void TriangleNonRightAngleTest()
        {
            var triangle = new Triangle(10, 10, 10);
            Assert.IsFalse(triangle.IsRightAngled);
        }
    }
}
