using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateArea;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleArea()
        {
            Circle circle = new Circle(5.5);
            double area = Math.PI * Math.Pow(5.5, 2);
            double currentArea = circle.Area;

            Assert.AreEqual(area, currentArea);
        }

        [TestMethod]
        public void TriangleArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double area = triangle.Area;
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void Rectangular()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool isOK = triangle.IsRectangular();
            Assert.IsTrue(isOK);
        }

        [TestMethod]
        public void FigureArea()
        {
            Figure figure = new Figure(new Triangle());
            double area = figure.Area;
            Assert.AreEqual(0, area);
     
        }
    }
}
