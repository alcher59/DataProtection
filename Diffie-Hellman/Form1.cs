using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Numerics;

namespace Diffie_Hellman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //проверка: простое ли число?
        private bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        private int Get_K(long x, long y)
        {
            int n = 43, q = 317;

            //int a = (int)(Math.Pow(q, x) % n);
            int b = (int)(Math.Pow(q, y) % n);
            int k = (int)(Math.Pow(b, x) % n);

            return k;
        }

        private void btn_enc_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox_x.Text.Length > 0) && (maskedTextBox_y.Text.Length > 0))
            {
                long x = Convert.ToInt64(maskedTextBox_x.Text);
                long y = Convert.ToInt64(maskedTextBox_y.Text);

                if (IsTheNumberSimple(x) && IsTheNumberSimple(y))
                {
                    textBox_crypt.Clear();
                    int k = Get_K(x, y);
                    string text = textBox_enc.Text.ToLower();
                    foreach (char i in text.ToCharArray())
                    {
                        if (textBox_crypt.Text.Length == 0)
                            textBox_crypt.Text = (i + k).ToString();
                        else
                            textBox_crypt.AppendText("\r\n" + (i + k));
                    }
                }
                else
                    MessageBox.Show("x или y - не простые числа!");
            }
            else
                MessageBox.Show("Введите x и y!");
        }

        private void btn_dec_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox_x.Text.Length > 0) && (maskedTextBox_y.Text.Length > 0))
            {
                long x = Convert.ToInt64(maskedTextBox_x.Text);
                long y = Convert.ToInt64(maskedTextBox_y.Text);

                string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

                int k = Get_K(x, y);
                List<string> input = new List<string>();
                textBox_dec.Clear();
                for (int i = 0; i < textBox_crypt.Lines.Length; i++)
                    input.Add(textBox_crypt.Lines[i]);
                string res = "";
                foreach (var str in input)
                {
                    for (int i = 97 + k; i <= 124 + k; i++)
                    {
                        if (str == i.ToString())
                            res += alphabet.GetValue(i - 97 - k) ;
                    }
                }
                textBox_dec.Text = res;
            }
            else
                MessageBox.Show("Введите секретный ключ!");
        }
    }
}
