using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorCorrection
{
    public partial class Form1 : Form
    {
        
        int r = 0; //степень полинома
        Dictionary<int, string> table = new Dictionary<int, string>(); //таблица порождающих полиномов
        List<int> polynom_H, polynom_P, polynom_F, polynom_R, polynom_Dev;

        public Form1()
        {
            InitializeComponent();
           
            table.Add(2, "111");
            table.Add(3, "1011");
            table.Add(4, "10011");
            table.Add(5, "100101");
            table.Add(6, "1000011");
            table.Add(7, "10001001");
            table.Add(8, "111100111");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            r = maskedTextBox1.Text.Length - 1;

            polynom_H = GetMulti(GetPolynom(maskedTextBox1.Text), r); // получим степени полинома h(x) = A(x)*x^r в нужном порядке 
            polynom_P = GetPolynom(table[r]);
            polynom_Dev = PolynomsDevision(polynom_H, polynom_P); // получим степени полинома остатка от деления h(x)/P(x) в нужном порядке

            polynom_F = polynom_H;
            polynom_F.AddRange(polynom_Dev); //результат = h(x) + остаток от деления

            textBox1.Text = GetString(polynom_F);
        }

        public string GetString(List<int> polynom)
        {
            string result = "";
            for (int i = polynom.Max(); i >= polynom.Min(); i--)
            {
                if (polynom.Contains(i))
                    result += "1";
                else
                    result += "0";
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var p1 = GetPolynom(textBox1.Text);

            polynom_R = PolynomsDevision(p1, polynom_P);

            if (polynom_R[0] == 0 && polynom_R.Count == 1)
            {
                textBox2.Text = "Ошибки нет.";
            }
            else
            {
                textBox2.Text = ErrorCorrection(textBox1.Text);
            }
        }

        public string ErrorCorrection(string str)
        {
            string res = textBox1.Text;
            string e = "";
            for (int j = 0; j < str.Length; j++)
            {
                if (j == 0) e += "1"; else e += "0";
            }
            var polynom_E = GetPolynom(e);

            var polynom_R0 = PolynomsDevision(polynom_E, polynom_P);

            for (int i = 0; i < str.Length; i++)
            {
                var polynom_Ri = PolynomsDevision(GetMulti(GetPolynom(textBox1.Text), i), polynom_P);

                if (Enumerable.SequenceEqual(polynom_Ri.OrderBy(t => t), polynom_R0.OrderBy(t => t))) //равны ли полиномы
                {
                    char element = res.ElementAt(i);
                    if (element == Convert.ToChar("0"))
                    {
                        res = res.Remove(i, 1).Insert(i, "1");
                    }
                    if (element == Convert.ToChar("1"))
                    {
                        res = res.Remove(i, 1).Insert(i, "0");
                    }
                }
            }

            return res;
        }

        public List<int> GetPolynom(string str) // получим степени полинома в нужном порядке 
        {
            List<int> degrees = new List<int>();
            int degree = str.Length - 1;
            foreach(char c in str)
            {
                if (c == '1')
                    degrees.Add(degree);
                degree--;
            }
            return degrees;
        }

        public List<int> GetMulti(List<int> polynom, int r) //polynom * r 
        {
            for(int i = 0; i < polynom.Count; i++)
            {
                polynom[i] += r;
            }
            return polynom;
        }

        public List<int> XOR(List<int> a, List<int> b) 
        {
            List<int> result = (from r in a.Union<int>(b) where !a.Intersect<int>(b).Contains<int>(r) select r).ToList<int>(); //симметричная разность
            
            return result;
        }

        public List<int> PolynomsDevision(List<int> p1, List<int> p2)  //остаток деления полиномов
        {
            List<int> temp1 = p1.ToList(); //временный список 1 для вычислений
            List<int> temp2 = new List<int>(); //временный список 2 для вычислений

            List<int> result = new List<int>(); //результат деления
            List<int> remainder = p1.ToList(); //остаток
            int i = 0;
            
            while (remainder[0] >= p2[0])
            {
                if (remainder[0] == p2[0])
                {
                    i++;
                    result.Add(0);
                }
                else
                {
                    result.Add(remainder[0] - p2[0]);
                }
                    
                for (int j = 0; j < p2.Count; j++)
                {
                    temp2.Add(result[i] + p2[j]);
                }

                remainder = XOR(temp1, temp2).OrderByDescending(x => x).ToList();
                temp1.Clear();
                temp2.Clear();
                temp1 = remainder.ToList();

                if(remainder.Count == 0)
                {
                    remainder.Add(0);
                    return remainder;
                }

                if (remainder[0] > p2[0])
                {
                    i++;
                }
            } 
            return remainder;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true ? textBox1.Text != "" : false;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true ? maskedTextBox1.Text != "" : false;
        }
    
    }
}
