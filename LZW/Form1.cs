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
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            foreach (var s in input.Text.Distinct())
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
                        currStr += inputStr[i + currStr.Length];
                    }
                }
            }
        }

        public void CompressText_AC() //arithmetic coding
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true ? input.Text != "" : false;
        }

        private void button2_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true ? output1.Text != "" : false;
        }
    }
}
