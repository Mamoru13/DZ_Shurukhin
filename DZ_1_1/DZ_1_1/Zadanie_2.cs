using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_1
{
    class Zadanie_2
    {
        public static void DZ_two()
        {
            ////Задание 1
            ////Написать метод, возвращающий минимальное из трёх чисел.
            //int min = 0;
            //Console.Write("Введите первое число: ");
            //int first = int.Parse(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //int second = int.Parse(Console.ReadLine());
            //Console.Write("Введите третье число: ");
            //int third = int.Parse(Console.ReadLine());
            //if (first < second && first < third) 
            //{
            //    min = first;
            //} else 
            //if (second < first && second < third)
            //{
            //    min = second;
            //} else 
            //if (third < first && third < second)
            //{
            //    min = third;
            //}
            //Console.WriteLine("Минимально число из введённых:  {0}" ,min);

            //Console.WriteLine();

            ////Задание 2
            ////Написать метод подсчета количества цифр числа.

            //long a = 139405;
            //int i = 0;
            //while (a > 0)                  // пока a больше нуля
            //{
            //    a = a / 10;              // отбрасываем от числа а последнюю цифру
            //    i++;
            //}
            //Console.WriteLine("Колличество цифр: {0}", i);      
            //Console.WriteLine();

            //Задание 3
            //С клавиатуры вводятся числа, пока не будет введен 0. 
            //Подсчитать сумму всех нечетных положительных чисел.



            //Задание 4
            //Реализовать метод проверки логина и пароля. 
            //На вход метода подается логин и пароль. 
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
            //С помощью цикла do while ограничить ввод пароля тремя попытками.
            int trycount = 3;

            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите логин: ");
                string pass = Console.ReadLine();
                if (login == "root" && pass == "GeekBrains")
                {
                    Console.WriteLine("Доступ получен");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не верно пару логин пароль, попробууйте ещё раз.");
                    --trycount;
                    Console.WriteLine("У вас осталось {0} попытки.", trycount);
                    if (trycount == 0)
                    {
                        Console.WriteLine("У вас кончились попытки, попробуйте позже.");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }
            while (trycount != 3);



        }

        static bool Odd(int a)
        {
            return a % 2 == 0;
        }

    }
}
