using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ_1_1
{
    class Message
    {
        //2. Разработать класс Message, содержащий следующие статические методы для обработки текста

        public static void Text()
        {
            FileStream stream = new FileStream("text.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string str = reader.ReadToEnd();
            stream.Close();
            Console.WriteLine(str);
            DZ_2a(str);
            Console.WriteLine();
            DZ_2b(str);
            Console.WriteLine();
            DZ_2v(str);


        }

        //а) Вывести только те слова сообщения, которые содержат не более n букв.

        public static void DZ_2a(string str)
        {
            Console.Write("Введите количество символов в слове: ");
            int n = int.Parse(Console.ReadLine());
            var msv = str.Split(new char[] { ' ', ',', '.', '!', '?', '-' }).Where(x => x.Length == n).ToArray();
            foreach (var item in msv)
            {
                Console.WriteLine(item);
            }
        }

        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.

        public static void DZ_2b(string str)
        {
            Console.Write("Введите символ: ");
            char x = char.Parse(Console.ReadLine());
            string p = "Удалены те слова которые заканчиваются на заданный символ {0}: {1}";
            // Удалить из сообщения все слова, которые заканчиваются на заданный символ
            string[] div = str.Split(' ', ',', '.', '-', '!', '?');
            for (int i = 0; i < div.Length; i++)
            {

                if (div[i].EndsWith(x.ToString()))
                {
                    Console.WriteLine(p, x, div[i]);
                }
            }
        }

        //в) Найти самое длинное слово сообщения.

        public static void DZ_2v(string str)
        {
            string[] text = str.Split(' ', '.', ',', '!', '?');
            int max = 0;
            string slovo = "";
            for (int i = 0; i < text.GetLength(0); i++)
            {
                if (text[i].Length > max)
                {
                    max = text[i].Length;
                    slovo = text[i];
                }
            }
            Console.WriteLine($"Самое длинное слово: {slovo}");
        }
    }
}
