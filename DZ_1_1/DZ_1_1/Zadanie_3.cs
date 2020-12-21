using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_1
{
    class Zadanie_3
    {
        public static void DZ_third()
        {
            //Третье задание
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //   Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            //Шурухин Александр Сергеевич

            Console.WriteLine("Введите переменные для расчёта расстояния: ");
            Console.Write("Введите x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между координатами равно: {0:F2}", r);
            Console.WriteLine();
        }
    }
}
