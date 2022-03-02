using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] header = { 'A', 'D', 'F', 'G', 'X' };
            char[][] columns = { new char[] { 'F', 'N', 'H', 'E', 'Q' },
                             new char[] { 'R', 'D', 'Z', 'O', 'C' },
                             new char[] { 'I', 'S', 'A', 'G', 'U' },
                             new char[] { 'B', 'V', 'K', 'P', 'W' },
                             new char[] { 'X', 'M', 'Y', 'T', 'L'}};

            Console.Write("Введите строку: ");
            char[] text = Console.ReadLine().ToUpper().Replace(" ", "").ToArray();
            Console.Write("Введите ключ: ");
            string key = Console.ReadLine().Replace(" ", "").ToUpper();

            string newText = "";
            for (int k = 0; k < text.Length; k++)
            {
                for (int i = 0; i < columns.Length; i++)
                {
                    for (int j = 0; j < columns[i].Length; j++)
                    {
                        if (text[k] == columns[i][j])
                        {
                            newText += header[i].ToString() + header[j];
                        }
                    }
                }
            }

            Coding[] str = new Coding[key.Length];

            for (int i = 0; i < str.Length; i++)
            {
                str[i] = new Coding();
                str[i].Symbol = key[i].ToString();
            }

            string row = "";

            for (int i = 0; i < newText.Length; i += key.Length)
            {
                row = new string(newText.Skip(i).Take(key.Length).ToArray());
                for (int j = 0; j < key.Length; j++)
                {
                    if (j + 1 > row.Length)
                    {
                        str[j].Row += "*";
                    }
                    else
                    {
                        str[j].Row += row[j];
                    }
                }
            }

            str = str.OrderBy(x => x.Symbol).ToArray();

            Console.WriteLine("Зашифрованная строка: " + string.Join("", str.Select(x => x.Row).ToArray()));

            Console.ReadLine();
        }
    }

    public class Coding
    {
        public string Symbol;
        public string Row;
    }
}
