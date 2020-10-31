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
        
        const int r = 3; //степень
        const string p = "1011"; // P(x) - порождающий полином при степени r

        public Form1()
        {
            InitializeComponent();
            maskedTextBox1.Mask = "0000"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var polynomH = GetH(GetPolynom(maskedTextBox1.Text));
            var polynomDev = PolynomsDevision(polynomH, GetPolynom(p));
            polynomH.AddRange(polynomDev);
            string result = "";
            for(int i = polynomH.Max(); i >= polynomH.Min(); i--)
            {
                if (polynomH.Contains(i))
                    result += "1";
                else
                    result += "0";
            }
            textBox1.Text = result;
        }

        public List<int> GetPolynom(string str) // получим степени полинома в нужном порядке 
        {
            List<int> degrees = new List<int>();
            int degree = r;
            foreach(char c in str)
            {
                if (c == '1')
                    degrees.Add(degree);
                degree--;
            }
            return degrees;
        }

        public List<int> GetH(List<int> degrees) // получим степени полинома h(x) = A(x)*x^r в нужном порядке 
        {
           
            for(int i = 0; i < degrees.Count; i++)
            {
                degrees[i] += r;
            }
            return degrees;
        }

        public List<int> XOR(List<int> a, List<int> b) 
        {
            List<int> result = (from r in a.Union<int>(b) where !a.Intersect<int>(b).Contains<int>(r) select r).ToList<int>(); //симметричная разность
            
            return result;
        }

        public List<int> GetElementsFrom(List<int> list)
        {
            List<int> newList = new List<int>();
            foreach (var i in list)
            {
                newList.Add(i);
            }
            return newList;
        }

        public List<int> PolynomsDevision(List<int> h, List<int> p) // получим степени полинома остатка от деления h(x)/P(x) в нужном порядке
        {
            List<int> temp1 = GetElementsFrom(h); //временный список 1 для вычислений
            List<int> temp2 = new List<int>(); //временный список 2 для вычислений
            List<int> result = new List<int>(); //результат деления
            List<int> remainder = GetElementsFrom(h); //остаток
            int i = 0;
            
            while (remainder[0] >= p[0])
            {
                if (remainder[0] == p[0])
                {
                    i++;
                    result.Add(0);
                }
                else
                {
                    result.Add(remainder[0] - p[0]);
                }
                    
                for (int j = 0; j < p.Count; j++)
                {
                    temp2.Add(result[i] + p[j]);
                }

                remainder = XOR(temp1, temp2);
                temp1.Clear();
                temp2.Clear();
                temp1 = GetElementsFrom(remainder);

                if (remainder[0] > p[0])
                {
                    i++;
                }
            } 
            return remainder;
        }
    }
}
