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
            open.InitialDirectory = @"C:\Temp\ПКС-81\Новая папка\PractWork3\PractWork6\bin\Debug";
            if (open.ShowDialog() == DialogResult.OK)
            {
                nameTextBox.Text = open.FileName;
                Coding.Extension = new FileInfo(open.FileName).Extension;
            }
        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            Coding.codes = new List<Coding>();
            string file = nameTextBox.Text;
            List<char> bytes2 = new List<char>();

            using (var stream = File.Open(file, FileMode.Open))
            {
                using (var reader = new BinaryReader(stream))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        bytes2.Add(Encoding.Unicode.GetChars(reader.ReadBytes(2))[0]);
                    }
                }
            }

            ////byte[] bytes = File.ReadAllBytes(file);
            //string result = "";
            //for (int i = 0; i < bytes.Length; i++)
            //{
            //    result += bytes[i].ToString() + " ";
            //}
            //MessageBox.Show(result);
            //File.WriteAllText("OldFile.txt", result);
            //Coding.oldFile = bytes;

            byte[] dec = Coding.Code(bytes2.ToArray());

            //result = "";
            //for (int i = 0; i < dec.Length; i++)
            //{
            //    result += dec[i].ToString() + " ";
            //}
            //Coding.codeFile = dec;
            //// MessageBox.Show(dec);
            //result = "";
            using (var streamWrite = File.Open("textNew" + Coding.Extension, FileMode.Create))
            {
                using (var writer = new BinaryWriter(streamWrite))
                {
                    for (int i = 0; i < dec.Length; i++)
                    {
                        writer.Write(dec[i]);
                    }
                }
            }
            //File.WriteAllBytes("textNew" + Coding.Extension, dec);

            MessageBox.Show("Шифрование выполнено!");
            //MessageBox.Show(File.ReadAllText("textNew.txt"));
            //MessageBox.Show(result);
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            List<byte> bytes2 = new List<byte>();
            //byte[] bytes = File.ReadAllBytes("textNew" + Coding.Extension);
            //string result = "";
            //for (int i = 0; i < bytes.Length; i++)
            //{
            //    result += bytes[i].ToString() + " ";
            //}

            using (var stream = File.Open("textNew" + Coding.Extension, FileMode.Open))
            {
                using (var reader = new BinaryReader(stream))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        bytes2.Add(reader.ReadByte());
                    }
                }
            }
            byte[] enc = Coding.Encode(String.Join("",bytes2.ToArray()));

            using (var stream = File.Open("textNewWOW" + Coding.Extension, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream))
                {
                    for (int i = 0; i < enc.Length; i++)
                    {
                        writer.Write(enc[i]);
                    }
                }
            }
            //File.WriteAllBytes("textNewWOW" + Coding.Extension, enc);

            //bytes = File.ReadAllBytes("textNewWOW" + Coding.Extension);
            //MessageBox.Show(result);
            //result = "";
            //for (int i = 0; i < bytes.Length; i++)
            //{
            //    result += bytes[i].ToString() + " ";
            //}
            //File.WriteAllText("NewFile.txt", result);
            //string text = "";
            //for (int i = 0; i < enc.Length; i++)
            //{
            //    text += String.Format("{0} {1} {2}{3}", Coding.oldFile[i], Coding.codeFile[i], enc[i], Environment.NewLine);
            //}
            //File.WriteAllText("Compare.txt", text);
            //if (Coding.oldFile == enc)//
            //{                            //
            //    //
            //    MessageBox.Show("Дешифрование удалось.");
            //}

            //string newText  = "";
            //string text = File.ReadAllText("textNewWOW.txt");
            //string[] symbols = text.Split(' ');
            //char symba;
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    symba = (char)Convert.ToInt32(symbols[i]);
            //    newText += symba;
            //}


            //File.WriteAllText("tha.txt", newText);
            MessageBox.Show("Дешифрование выполнено!");


        }
    }

    class Coding
    {
        static public byte[] oldFile;
        static public byte[] codeFile;
        public int D;
        public int N;
        static public List<Coding> codes = new List<Coding>();
        static public string Extension;

        static public string Code(string message)
        {
            string result = "";
            char[] mgs = message.ToCharArray();
            for (int k = 0; k < mgs.Length; k++)
            {
                int encode = 0;
                {
                    int symbol = (int)mgs[k];
                    int n = 0;
                    int first = 0;
                    int second = 0;
                    do
                    {
                        first = SimpleNumber();
                        do
                        {
                            second = SimpleNumber();
                        }
                        while (second == first);
                        n = first * second;
                    } while (n < symbol);

                    int fn = (first - 1) * (second - 1);
                    int e = 0;
                    for (int i = 2; i < fn; i++)
                    {
                        if (IsSimple(i) && IsSimple(fn + i))
                        {
                            e = i;
                            break;
                        }
                    }

                    int d = 0;
                    int j = 2;

                    while (d == 0)
                    {
                        if (IsSimple(j) && (j * e) % fn == 1)
                        {
                            d = j;
                        }
                        j++;
                    }

                    encode = 1;
                    for (int i = 0; i < e; i++)
                    {
                        encode = (symbol * encode) % n;
                    }
                } while (encode > 65536)

                    codes.Add(new Coding()
                    {
                        D = d,
                        N = n
                    });

                result += (char)encode;
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
                int code = 1;
                for (int i = 0; i < codes[k].D; i++)
                {
                    code = (symbol * code) % codes[k].N;
                }
                result += (char)code;
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

            int maxNumbers = 300;

            bool isPrime;
            for (int j = 100; j < maxNumbers; j++)
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
