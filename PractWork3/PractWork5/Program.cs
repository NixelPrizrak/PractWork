using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PractWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            int second = 0;
            int first = Coding.SimpleNumber();
            do
            {
                second = Coding.SimpleNumber();
            }
            while (second == first);
            int n = first * second;

            int fn = (first - 1) * (second - 1);
            int exp = 0;
            for (int i = 2; i < fn; i++)
            {
                if (Coding.IsSimple(i) && Coding.IsSimple(fn + i))
                {
                    exp = i;
                    break;
                }
            }

            int d = 0;
            int j = 2;

            while (d == 0)
            {
                if (Coding.IsSimple(j) && (j * exp) % fn == 1)
                {
                    d = j;
                }
                j++;
            }
            Coding.D = d;
            Coding.N = n;
            Coding.E = exp;

            Console.Write("Введите строку для шифрования: ");
            string msg = Console.ReadLine();
            string dec = Coding.Code(msg);
            Console.WriteLine("ЗАШИФРОВАНАЯ СТРОКА: " + dec);
            Console.WriteLine();
            Console.WriteLine("ДЕШИФРОВАНАЯ СТРОКА: " + Coding.Encode(dec));
            Console.ReadLine();
        }
    }

    class Coding
    {
        public static int D;
        public static int N;
        public static int E;
        static List<Coding> codes = new List<Coding>();

        static public string Code(string message)
        {
            string result = "";
            char[] mgs = message.ToCharArray();
            for (int k = 0; k < mgs.Length; k++)
            {
                int symbol = (int)mgs[k];

                if (symbol < N)
                {
                    int encode = 1;
                    for (int i = 0; i < E; i++)
                    {
                        encode = (symbol * encode) % N;
                    }
                    result += (char)encode;
                }
                else
                {
                    result += (char)symbol;
                }
            }

            return result;
        }

        static public string Encode(string message)
        {
            string result = "";
            char[] mgs = message.ToArray();
            for (int k = 0; k < mgs.Length; k++)
            {
                int symbol = (int)mgs[k];
                if (symbol < N)
                {
                    int code = 1;
                    for (int i = 0; i < D; i++)
                    {
                        code = (symbol * code) % N;
                    }
                    result += (char)code;
                }
                else
                {
                    result += (char)symbol;
                }
            }
            return result;
        }

        static public bool IsSimple(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static public int SimpleNumber()
        {
            Random random1 = new Random();
            List<int> nsS = new List<int>();

            int maxNumbers = 200;

            bool isPrime;
            for (int j = 3; j < maxNumbers; j++)
            {
                isPrime = true;
                for (int i = 2; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    nsS.Add(j);
                }
            }

            return nsS[random1.Next(0, nsS.Count)];
        }
    }
}
