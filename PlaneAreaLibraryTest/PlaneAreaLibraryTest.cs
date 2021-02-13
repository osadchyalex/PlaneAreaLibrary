using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlaneAreaLibrary;
using System;

namespace PlaneAreaLibraryTest
{
    [TestClass]
    public class CircleAreaTest
    {
        [TestMethod]
        public void CircleArea_Normal() //Заведомо правильное решение
        {
            Assert.AreEqual(Circle.Area(10), Math.PI * Math.Pow(10, 2));
        }
    }

    [TestClass]
    public class CircleExistsTest
    {
        [TestMethod]
        public void CircleArea_zero() //Если радиус круга 0
        {
            Assert.AreEqual(Circle.Area(0), "Круг не существует");
        }

        [TestMethod]
        public void CircleArea_negative() //Если радиус круга отрицательный
        {
            Assert.AreEqual(Circle.Area(-10), "Круг не существует");
        }

        [TestMethod]
        public void CircleArea_PositiveInfinity() //Если радиус круга бесконечный
        {
            Assert.AreEqual(Circle.Area(double.PositiveInfinity), "Круг не существует");
        }
    }

    [TestClass]
    public class TriangleAreaTest
    {

        [TestMethod]
        public void TriangleArea_Normal() //Заведомо правильное решение
        {
            Assert.AreEqual(Triangle.Area(6, 8 ,10), 24);
        }
    }

    [TestClass]
    public class TriangleRightTest
    {
        [TestMethod]
        public void TriangleRight_Right() //Заведомо прямоугольный треугольник
        {
            Assert.AreEqual(Triangle.Right(6, 8, 10), true);
        }

        public void TriangleArea_NORight() //Заведомо не прямоугольный треугольник
        {
            Assert.AreEqual(Triangle.Right(5, 8, 10), false);
        }


    }

    [TestClass]
    public class TriangleExistsTest
    {
        [TestMethod]
        public void TriangleArea_zero() //Если одна сторона треугольника равна 0
        {
            Assert.AreEqual(Triangle.Area(0, 10, 20), "Треугольник не существует");
        }

        public void TriangleArea_zero2() //Если все стороны треугольника равны 0
        {
            Assert.AreEqual(Triangle.Area(0, 0, 0), "Треугольник не существует");
        }

        [TestMethod]
        public void TriangleArea_negative1() //Если одна сторона треугольника отрицательная
        {
            Assert.AreEqual(Triangle.Area(-6, 8, 10), "Треугольник не существует");
        }

        [TestMethod]
        public void TriangleArea_negative2() //Если все стороны треугольника отрицательные
        {
            Assert.AreEqual(Triangle.Area(-10, -6, -8), "Треугольник не существует");
        }

        [TestMethod]
        public void TriangleArea_PositiveInfinity1() //Если одна сторона треугольника бесконечна
        {
            Assert.AreEqual(Triangle.Area(double.PositiveInfinity, 10, 20), "Треугольник не существует");
        }


        [TestMethod]
        public void TriangleArea_PositiveInfinity2() //Если все стороны треугольника бесконечны
        {
            Assert.AreEqual(Triangle.Area(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), "Треугольник не существует");
        }


    }

}
