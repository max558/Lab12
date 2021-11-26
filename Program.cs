using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    /*
     * Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода: 
     * метод, определяющий длину окружности по заданному радиусу; 
     * метод, определяющий площадь круга по заданному радиусу; 
     * метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            double r = 2.5;

            Console.WriteLine("Задана окружность радиусом R = {0:f2}", r);
            Console.WriteLine("Длина окружности L= 2*pi*R = {0:f2}", Circle.LengthCircle(r));
            Console.WriteLine("Площадь окружности S= pi*R^2 = {0:f2}", Circle.SquareCircle(r));
            Circle.ComparPointCircle(2, 0, r, 0, 0);

            Console.ReadKey();
        }
    }
    public static class Circle
    {
        public static double LengthCircle(double r)
        {
            double res = 0;
            res = 2 * Math.PI * r;
            return res;
        }
        public static double SquareCircle(double r)
        {
            double res = 0;
            res = Math.PI * Math.Pow(r, 2);
            return res;
        }
        public static void ComparPointCircle(int pointX, int pointY, double circleR, int centrPointCircleX = 0, int centrPointCircleY = 0)
        {
            //Определяем длину от центра окружности до точки
            double L = Math.Sqrt(Math.Pow((centrPointCircleX - pointX), 2) + Math.Pow((centrPointCircleY - pointY), 2));
            string str = "";
            if (L <= circleR)
            {
                str = "принадлежит";
            }
            else
            {
                str = "не принадлежит";
            }

            Console.WriteLine(
                "Точка с координатами ({0};{1}) {4} окружности с радиусом {5:f2} и с центром в точке ({2};{3})",
                pointX, pointY, centrPointCircleX, centrPointCircleY, str, circleR);
        }
    }
}
