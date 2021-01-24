using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_1
{
    delegate double function(double arg, double arg2); //для задания 1
    delegate double func(double x); // для задания 2

    class DZ_6
    {
        #region Задание 1 (готово)
        public static void Zadanie_1()
        {
            //Изменить программу вывода функции так, чтобы можно было передавать функции типа double(double, double).
            //Продемонстрировать работу на функции с функцией a*x ^ 2 и функцией a* sin(x).

            Console.WriteLine("Таблица функции a*x^2");
            Table(delegate (double a, double x) { return a * x * x; }, -3, -3, 3);
            Console.WriteLine("Таблица функции a*sin(x)");
            Table(delegate (double a, double x) { return a * Math.Sin(x); }, -3, -3, 3);

        }

        // перегруженый метод для решения задачи
        public static void Table(function F, double a, double x, double b)
        {
            Console.WriteLine("------- X ------ Y -----\n");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("------------------------\n");
        }

        public static void PlotX(function f, double a, double x)
        {
            Console.WriteLine($"f({a},{x}) = {Math.Round(f(a,x), 2)}");
            Console.WriteLine();
        }

        public static double Funcia(double a, double x)
        {
            return a * (x * x);
        }

        public static double sin(double a, double x)
        {
            return a * Math.Sin(x);
        }
        #endregion

        #region Задание 2 (готово)

        public static void Zadanie_2()
        {
            //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
            //а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
            //б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
            //в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она
            //возвращает минимум через параметр.

            func[] F = { First, Second, Third};
            Console.WriteLine("По какой функции, искать минимум: 1 - функция x * x - 50 * x + 10");
            Console.WriteLine("                                  2 - функция x * x - 10 * x + 50");
            Console.WriteLine("                                  3 - функция x * x - 20 * x + 30");
            int index = int.Parse(Console.ReadLine());
            SaveFunc("data.bin", -100, 100, 0.5, F[index - 1]);
            Console.WriteLine(Load("data.bin"));
        }

        public static double First(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double Second(double x)
        {
            return x * x - 10 * x + 50;
        }

        public static double Third(double x)
        {
            return x * x - 20 * x + 30;
        }

        public static void SaveFunc(string fileName, double a, double b, double h, func F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        #endregion


        #region Задание 3 (доделать)
        public static void Zadanie_3()
        {
            //Переделать программу «Пример использования коллекций» для решения следующих задач:
            //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
            //в) отсортировать список по возрасту студента;
            //г) *отсортировать список по курсу и возрасту студента;
            //д) разработать единый метод подсчета количества студентов по различным параметрам
            //выбора с помощью делегата и методов предикатов.
            //*Достаточно решить 2 задачи.Старайтесь разбивать программы на подпрограммы.Переписывайте в начало программы условие и свою фамилию. Все программы сделайте в одном решении.

            int bakalavr = 0;
            int magistr = 0;
            List<Student> list = new List<Student>();                             // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_6.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[5]) < 5) bakalavr++; else magistr++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            list.Sort(new Comparison<Student>(MyDelegat));
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            foreach (var v in list) Console.WriteLine(v.firstName);
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();

        }

        static int MyDelegat(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {

            return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
        }


    }

    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        int age;
        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }

    }
    #endregion
}
