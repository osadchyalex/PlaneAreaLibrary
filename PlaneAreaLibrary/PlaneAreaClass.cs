using System;

namespace PlaneAreaLibrary
{

    public class Circle
    {
        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public static dynamic Area(double r)
        {
            if (ExistsCircle(r) == true)// Проверка на существование круга
            {
                return (Math.PI * Math.Pow(r, 2));  
            }     
            return "Круг не существует";

        }

        /// <summary>
        /// Проверка на существование круга
        /// </summary>
        /// <returns>true- круг существует, false- круг не существует</returns>
        public static bool ExistsCircle(double r)
        {
            if (r > 0 && r != double.PositiveInfinity)  //Проверка радиуса круга на то, что он положительное рациональное число
            {
                return true;
            }
            return false;
        }
    }


    public class Triangle
    {
        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public static dynamic Area(double a, double b, double c)
        {
            if (ExistsTriangle(a, b, c) == true)
            {

                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return "Треугольник не существует";
        }

        /// <summary>
        /// Проверка на "прямоуольность" треугольника
        /// </summary>
        /// <returns>true- треугольник прямоугольный, false- треугольник не прямоугольный</returns>
        public static dynamic Right(double a, double b, double c)
        {

            if (ExistsTriangle(a, b, c) == true)
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2) || Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2) || Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    return true;
                }
                return false;
            }
            return "Треугольник не существует";     
        }

        /// <summary>
        ///Проверка на существование треугольника
        /// </summary>
        /// <returns>true- треугольник существует, false- треугольник не существует</returns>
        public static bool ExistsTriangle(double a, double b, double c) //Проверка сторон треугольника на то, что они положительные рациональные числа
        {
            if (a > 0 && b > 0 && c > 0 && (a < b + c || b < a + c || c < b + a)&&(a!= double.PositiveInfinity && b != double.PositiveInfinity && c != double.PositiveInfinity))
                {
                return true;
                }
            return false;

        }
    }
}

