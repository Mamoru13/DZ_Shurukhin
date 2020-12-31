using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первое задание
            //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.

            //Шурухин Александр Сергеевич


            //Ввод имени
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            //Ввод фамилии
            Console.Write("Введите фамилию: ");
            string sec_name = Console.ReadLine();
            //Ввод возраста
            Console.Write("Введите возраст: ");
            byte let = byte.Parse(Console.ReadLine());
            //Ввод роста
            Console.Write("Введите рост в метрах: ");
            float rost = float.Parse(Console.ReadLine());
            //Ввод веса
            Console.Write("Введите вес в килограммах: ");
            float ves = float.Parse(Console.ReadLine());

            //Вывод информации
            //а) используя склеивание;
            Console.WriteLine("Вывод склеиванием");
            Console.WriteLine("Здравствуйте " + name + " " + sec_name + ". " + 
                "Вам " + Convert.ToString(let) + " лет. " + 
                "Ваш рост " + Convert.ToString(rost) + ". " + 
                "Ваш вес " + Convert.ToString(ves) + ".");
            //б) используя форматированный вывод;
            Console.WriteLine("Форматированный вывод");
            Console.WriteLine(String.Format("Здравствуйте {0} {1}. Вам {2} лет. Ваш рост {3}. Ваш вес {4}.", name, sec_name, let, rost, ves));
            //в) используя вывод со знаком $.
            Console.WriteLine("Вывод со знаком '$'");
            Console.WriteLine($"Здравствуйте {name} {sec_name}. Вам {let} лет. Ваш рост {rost}. Ваш вес {ves}.");

            //Второе задание
            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            //Шурухин Александр Сергеевич

            //Расчёт ИМТ
            float i = ves / (rost * rost);

            //Вывод ИМТ
            Console.WriteLine(String.Format("Ваш ИМТ равен {0:F1}.", i));

            Console.WriteLine();
            
            //Третье задание
            Zadanie_3.DZ_third();

            Console.WriteLine();

            //Четвёртое задание
            Zadanie_4.DZ_Fourth();

            Console.WriteLine();

            //Пятое задание
            Zadanie_5.DZ_Five();

            //Шестое задание в классе 'My'

            Console.Write("Нажмите клавишу 'Enter' для выхода.");
            My.Pause();



        }
    }
}
