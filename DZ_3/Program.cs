using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{

    enum MathVich : byte
    {
        Sum = 1,
        Vichitanie = 2,
        Proisvedenie = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.
            //Шурухин Александр Сергеевич

            Complex z1 = new Complex(5, -6, "");

            z1.Print();

            Complex z2 = new Complex(-3, 2, "");

            z2.Print();

            MathVich level;
            int user;
            do
            {
                Console.Write("Произвести Сумму(Введите '1'), Вычитание(Введите '2') или произведение(Введите '3') комплексных чисел? ");
                int.TryParse(Console.ReadLine(), out user); //проверка на строковый ввод      
            } while (user < 1 || user > 3);

            if (user == 1) level = MathVich.Sum;
            else if (user == 2) level = MathVich.Vichitanie;
            else level = MathVich.Proisvedenie;

            switch (level)
            {
                case MathVich.Sum:
                    //сумма комплексных чисел
                    Console.WriteLine("Сумма комплексных чисел ");
                    Complex z = Complex.Sum(z1, z2);
                    z.Print();
                    break;

                case MathVich.Vichitanie:
                    //вычитание комплексных чисел
                    Console.WriteLine("Вычитание комплексных чисел ");
                    Complex x = Complex.Vich(z1, z2);
                    x.Print();
                    break;

                case MathVich.Proisvedenie:
                    //произведение комплексных чисел
                    Console.WriteLine("Произведение комплексных чисел ");
                    Complex y = Complex.Prois(z1, z2);
                    y.Print();
                    break;

                default:
                    break;
            }

            Console.ReadKey(); //Задержка чёрного экрана
        }
    }
}
