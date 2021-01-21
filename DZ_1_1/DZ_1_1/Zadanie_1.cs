using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_1
{
    class Zadanie_1
    {
        public static void DZ_One()
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

            Console.WriteLine();

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

            Console.WriteLine();

            //Пятое задание
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) *Сделать задание, только вывод организовать в центре экрана.

            //Шурухин Александр Сергеевич

            //Ввод возраста
            Console.Write("Введите город: ");
            string city = Console.ReadLine();
            Console.WriteLine(" {0,45} {1,2} из города {2,2}", name, sec_name, city);
        }
    }
}
