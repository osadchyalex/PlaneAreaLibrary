using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlaneAreaLibrary;
using System;

namespace PlaneAreaLibraryTest
{
    [TestClass]
    public class CircleAreaTest
    {
        [TestMethod]
        public void CircleArea_Normal() //�������� ���������� �������
        {
            Assert.AreEqual(Circle.Area(10), Math.PI * Math.Pow(10, 2));
        }
    }

    [TestClass]
    public class CircleExistsTest
    {
        [TestMethod]
        public void CircleArea_zero() //���� ������ ����� 0
        {
            Assert.AreEqual(Circle.Area(0), "���� �� ����������");
        }

        [TestMethod]
        public void CircleArea_negative() //���� ������ ����� �������������
        {
            Assert.AreEqual(Circle.Area(-10), "���� �� ����������");
        }

        [TestMethod]
        public void CircleArea_PositiveInfinity() //���� ������ ����� �����������
        {
            Assert.AreEqual(Circle.Area(double.PositiveInfinity), "���� �� ����������");
        }
    }

    [TestClass]
    public class TriangleAreaTest
    {

        [TestMethod]
        public void TriangleArea_Normal() //�������� ���������� �������
        {
            Assert.AreEqual(Triangle.Area(6, 8 ,10), 24);
        }
    }

    [TestClass]
    public class TriangleRightTest
    {
        [TestMethod]
        public void TriangleRight_Right() //�������� ������������� �����������
        {
            Assert.AreEqual(Triangle.Right(6, 8, 10), true);
        }

        public void TriangleArea_NORight() //�������� �� ������������� �����������
        {
            Assert.AreEqual(Triangle.Right(5, 8, 10), false);
        }


    }

    [TestClass]
    public class TriangleExistsTest
    {
        [TestMethod]
        public void TriangleArea_zero() //���� ���� ������� ������������ ����� 0
        {
            Assert.AreEqual(Triangle.Area(0, 10, 20), "����������� �� ����������");
        }

        public void TriangleArea_zero2() //���� ��� ������� ������������ ����� 0
        {
            Assert.AreEqual(Triangle.Area(0, 0, 0), "����������� �� ����������");
        }

        [TestMethod]
        public void TriangleArea_negative1() //���� ���� ������� ������������ �������������
        {
            Assert.AreEqual(Triangle.Area(-6, 8, 10), "����������� �� ����������");
        }

        [TestMethod]
        public void TriangleArea_negative2() //���� ��� ������� ������������ �������������
        {
            Assert.AreEqual(Triangle.Area(-10, -6, -8), "����������� �� ����������");
        }

        [TestMethod]
        public void TriangleArea_PositiveInfinity1() //���� ���� ������� ������������ ����������
        {
            Assert.AreEqual(Triangle.Area(double.PositiveInfinity, 10, 20), "����������� �� ����������");
        }


        [TestMethod]
        public void TriangleArea_PositiveInfinity2() //���� ��� ������� ������������ ����������
        {
            Assert.AreEqual(Triangle.Area(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), "����������� �� ����������");
        }


    }

}
