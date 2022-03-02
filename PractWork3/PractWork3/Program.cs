using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            char[] text = Console.ReadLine().ToLower().ToArray();
            Console.Write("Введите ключ: ");
            string key = Console.ReadLine().ToLower();
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            for (int i = 0; i < text.Length; i++)
            {
                int indexText = alphabet.IndexOf(text[i]);
                int indexKey = alphabet.IndexOf(key[i % key.Length]);
                text[i] = alphabet[(indexText + indexKey) % alphabet.Length];
            }

            Console.WriteLine("Зашифрованная строка: " + string.Join("", text));

            Console.ReadLine();
        }
    }
}
