using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DZ_1_1
{
    class DZ_5
    {
        //1.Создать программу, которая будет проверять корректность ввода логина.
        //  Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        public static void DZ_5_1a()
        {
            //а) без использования регулярных выражений;
            Console.Write("Введите логин:");
            string login = Console.ReadLine();

            // Проверка на длину
            if (login.Length > 2 || login.Length < 10)
            {
                // Проверка первого символа на цифру
                if (!Char.IsDigit(login[0]))
                {
                    bool correct = true;
                    for (int i = 0; i < login.Length; i++)
                    {
                        //if (!Char.IsLetterOrDigit(login[i]))//проверка вводимого логина (принимает все символы)
                        if ((login[i] >= 'a' && login[i] <= 'z') || (login[i] >= 'A' && login[i] <= 'Z') || (login[i] >= '0' && login[i] <= '9'))//проверка на латинские символы и цифры
                        { 
                            correct = true;
                        }
                        else
                        {
                            correct = false;
                            break;
                        }
                    }
                    if (correct)
                    {
                        Console.WriteLine("Логин верен");
                    }
                    else
                    {
                        Console.WriteLine("Логин не верен. Он должен содержать только латинские буквы или цифры.");
                    }
                }
                else
                {
                    Console.WriteLine("Логин не верен. первым символом должна быть буква.");
                }
            }
            else
            {
                Console.WriteLine("Логин не верен. Длина должна быть нот 2х до 10ти символов.");
            }
        }

        public static void DZ_5_1b()
        {
            //б) с использованием регулярных выражений.
            Regex regex = new Regex("^[a-zA-Z][a-zA-Z0-9]{2,9}$");
            Console.Write("Введите логин:");
            string login = Console.ReadLine();

            if (regex.Match(login).Success) // проверка на совпадение
            {
                Console.WriteLine("Введён верно.");
            }
            else
            {
                Console.WriteLine("Логин введён не верною.");
            }
        }
    }
}
