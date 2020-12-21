using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_1
{
    class Zadanie_4
    {
        public static void DZ_Fourth()
        {
            //Четвёртое задание
            //Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.
            
            //Шурухин Александр Сергеевич

            int third = 0;
            Console.WriteLine("Введите переменные для обмена значениями: ");
            Console.Write("Введите первую переменную: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Введите вторую переменную: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Первое число = {0}, а второе {1}.", first, second);
            Console.WriteLine();
            //при помощи третьей переменной
            third = first;
            first = second;
            second = third;
            Console.WriteLine("Теперь первое число = {0}, а второе = {1}.", first, second);
            Console.WriteLine();
            //возвращаем на места, без помощи третьей переменной
            first = first + second;
            second = first - second;
            first = first - second;
            Console.WriteLine("Вернули на места первое число = {0} и второе = {1}.", first, second);
        }
    }
}
