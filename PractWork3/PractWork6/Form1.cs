using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PractWork6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nameTextBox.Text = Environment.CurrentDirectory + @"\text.txt";
            Coding.Extension = ".txt";
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.CurrentDirectory;
            if (open.ShowDialog() == DialogResult.OK)
            {
                nameTextBox.Text = open.FileName;
                Coding.Extension = new FileInfo(open.FileName).Extension;
            }
        }

        private void codeButton_Click(object sender, EventArgs e)
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
            Coding.N = n;
            Coding.D = d;
            Coding.E = exp;

            string file = nameTextBox.Text;
            byte[] bytes = File.ReadAllBytes(file);

            byte[] dec = Coding.Code(bytes);

            File.WriteAllBytes("textNew" + Coding.Extension, dec);
            MessageBox.Show("Шифрование выполнено!");
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            byte[] bytes = File.ReadAllBytes("textNew" + Coding.Extension);

            byte[] enc = Coding.Encode(bytes);
            File.WriteAllBytes("textNewWOW" + Coding.Extension, enc);

            MessageBox.Show("Дешифрование выполнено!");
        }
    }

    class Coding
    {
        public static int D;
        public static int N;
        public static int E;
        static public string Extension;

        static public byte[] Code(byte[] bytes)
        {
            List<byte> result = new List<byte>();

            for (int k = 0; k < bytes.Length; k++)
            {
                int symbol = (int)bytes[k];
                int encode = 1;
                if (symbol < N)
                {
                    for (int i = 0; i < E; i++)
                    {
                        encode = (symbol * encode) % N;
                    }
                    result.Add((byte)encode);
                }
                else
                {
                    result.Add((byte)symbol);
                }
            }

            return result.ToArray<byte>();
        }

        static public byte[] Encode(byte[] message)
        {
            List<byte> result = new List<byte>();
            for (int k = 0; k < message.Length; k++)
            {
                int symbol = (int)message[k];
                int code = 1;
                if (symbol < N)
                {
                    for (int i = 0; i < D; i++)
                    {
                        code = (symbol * code) % N;
                    }
                    result.Add((byte)code);
                }
                else
                {
                    result.Add((byte)symbol);
                }
            }
            return result.ToArray();
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

            int maxNumbers = 18;

            bool isPrime;
            for (int j = 7; j < maxNumbers; j++)
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
