using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine().ToLower();
            List<string> str = new List<string>();

            for (int i = 0; i < text.Length; i += 3)
            {
                str.Add(new string(text.Skip(i).Take(3).ToArray()));
            }

            text = "";
            for (int i = 0; i < str.Count; i++)
            {
                if (str[i].Length < 3)
                {
                    int empty = 3 - str[i].Length;
                    for (int j = 0; j < empty; j++)
                    {
                        str[i] += "*";
                    }
                }

                str[i] += str[i][0];
                str[i] = str[i].Remove(0, 1);
                text += str[i];
            }

            Console.WriteLine("Зашифрованная строка: " + text);
            Console.ReadLine();
        }
    }
}
