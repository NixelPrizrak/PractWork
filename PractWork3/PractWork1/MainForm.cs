using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        char[] alphabet;
        public MainForm()
        {
            InitializeComponent();
            alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        }

        private void codedButton_Click(object sender, EventArgs e)
        {
            char[] text = wordTextBox.Text.ToUpper().Replace("J", "I").ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (alphabet[j] == text[i])
                    {
                        text[i] = alphabet[(j + 5) % alphabet.Length];
                    }
                }
            }
            newStringLabel.Text = "Результат: " + new string(text);
        }
    }
}
