using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LZW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            input.Text = "abacabadabacabae";
            output1.Text = "ЭТОТ_МЕТОД_ЛУЧШЕ_ХАФФМАНА";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output1.Clear();
            CompressText_LZW();
        }

        public void CompressText_LZW() //Lempel-Ziv-Welch
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            string inputStr = input.Text;

            string currStr = inputStr.Substring(0, 2);  //текущая строка
            string curr = "";  //текущий символ
            string next = ""; //следующий символ

            int num = 0; //номер элемента в словаре

            foreach (var s in inputStr.Distinct())
            {
                dict.Add(num, s.ToString());
                num++;
            }

            int tempNum = num;
            for (int i = 0; i < inputStr.Length; i++)
            {
                curr = inputStr[i].ToString();

                if(i == inputStr.Length - 1)
                {
                    output1.Text += dict.FirstOrDefault(x => x.Value == curr).Key;
                }
                else
                {
                    next = inputStr[i + 1].ToString();

                    if (tempNum < num)
                    {
                        currStr = curr + next;
                        tempNum++;
                    }

                    if (!dict.Values.Contains(currStr))
                    {
                        dict.Add(num, currStr);
                        num++;
                        output1.Text += dict.FirstOrDefault(x => x.Value == currStr.Remove(currStr.Length - 1, 1)).Key;
                        currStr = "";
                    }
                    else
                    {
                        if(i + currStr.Length < inputStr.Length)
                        {
                            currStr += inputStr[i + currStr.Length];
                        }
                    }
                }
            }
        }

        public void CompressText_AC() //arithmetic coding
        {
            Dictionary<string, double> dict = new Dictionary<string, double>(); //символ/вероятность
            List<string> inputList = new List<string>(); //список входных символов

            string inputStr = output1.Text;

            var list = inputStr.Distinct(); //последовательность элементов
            foreach (var s in inputStr)
            {
                inputList.Add(s.ToString());
            }

            foreach (var obj in list)
            {
                dict.Add(obj.ToString(), inputStr.Count(x => x == obj) / (double)inputStr.Length);
            }

            var items = from pair in dict orderby pair.Value descending select pair; //сортировка по убыванию

            dict = items.ToDictionary(x => x.Key, y => y.Value);

            Dictionary<string, double> section = new Dictionary<string, double>(); //отрезок

            int counter = 0;
            foreach(var pair in dict)
            {
                if(counter != 0)
                {
                    double prev = section.ElementAt(counter - 1).Value;
                    section.Add(pair.Key, dict.ElementAt(counter - 1).Value + prev );
                }
                else
                {
                    section.Add(pair.Key, pair.Value);
                }
                counter++;
            }

            for (int i = 1; i < inputStr.Length; i++) 
            {
                double high_old = section[inputList[i - 1]];
                double low_old = section.ElementAtOrDefault(section.Values.ToList().IndexOf(high_old) - 1).Value;

                double range_hi = section[inputList[i]];

                double high = low_old + (high_old - low_old) * range_hi; //для кодировки символа будем использовать число равное верхней границе

                output2.Text += high.ToString() + "  ";
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true ? input.Text != "" : false;
        }

        private void output1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true ? output1.Text != "" : false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            output2.Clear();
            CompressText_AC();
        }
    }
}
