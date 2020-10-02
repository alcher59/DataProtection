using System;
using System.Windows.Forms;

namespace Diffie_Hellman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

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
            int n = 3, q = 5;

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
                    foreach (char t in text.ToCharArray())
                        for (int i = 97; i <= 124; i++)
                            if (t + k == i)
                                textBox_crypt.Text += alphabet.GetValue(t + k - 97).ToString();
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

                textBox_dec.Clear();
                int k = Get_K(x, y);
                string text = textBox_crypt.Text.ToLower();
                foreach (char t in text.ToCharArray())
                    for (int i = 97; i <= 124; i++)
                        if (t - k == i)
                            textBox_dec.Text += alphabet.GetValue(t - k - 97).ToString();
            }
            else
                MessageBox.Show("Введите секретный ключ!");
        }
    }
}
