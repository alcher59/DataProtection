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
        const string P = "1011"; // P(x) - порождающий полином при степени r

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
                degrees[i] += 3;
            }
            return degrees;
        }

        public List<int> XOR(List<int> a, List<int> b) 
        {
            List<int> result = (from r in a.Union<int>(b) where !a.Intersect<int>(b).Contains<int>(r) select r).ToList<int>(); //симметричная разность
            
            return result;
        }

        public List<int> PolynomsDevision(List<int> h, List<int> p) // получим степени полинома остатка от деления h(x)/P(x) в нужном порядке
        {
            List<int> temp1 = new List<int>(); //временный список 1 для вычислений
            List<int> temp2 = new List<int>(); //временный список 2 для вычислений
            List<int> result = new List<int>(); //результат деления
            List<int> remainder = new List<int>(); //остаток
            

            for (int i = 0; i < h.Count; i++)
            {
                result[i] = h[i] - p[i];
                for (int j = 0; j < p.Count; j++)
                {
                    temp1[j] = result[i] + p[j];
                }

            }
            return result;
        }
    }
}
