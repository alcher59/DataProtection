using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamma
{
    public partial class Form1 : Form
    {
        private const int blockSize = 64; //размер блока 32 бит(в unicode символ в два раза длинее)
        private const int charSize = 16;
        string[] inputBlocks; //блоки исходного текста в двоичном формате
        string[] gammaBlocks; //гамма блоки в двоичном формате

        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public Form1()
        {
            InitializeComponent();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true ? inputBox.Text.Length >= 2 : button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = inputBox.Text;

            str = StringToRightLength(str);
            inputBlocks = CutStringToBlocks(str);

            string gamma = "";


            for (int i = 0; i < str.Length; i++)
            {
                Random rnd = new Random();
                var s = alphabet.GetValue(rnd.Next(0, alphabet.Length - 1));

                gamma += s.ToString();
            }

            gammaBlocks = CutStringToBlocks(gamma);

            string result = "";

            for (int i = 0; i < inputBlocks.Length; i++)
            {
                result += XOR(inputBlocks[i], gammaBlocks[i]);
            }

            outputBox.Text = StringFromBinaryToNormalFormat(result);
        }

      

        //разбиение строки на блоки
        private string[] CutStringToBlocks(string input)
        {
            string[] blocks = new string[(input.Length * charSize) / blockSize];

            int lengthOfBlock = input.Length / blocks.Length;

            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = input.Substring(i * lengthOfBlock, lengthOfBlock);
                blocks[i] = StringToBinaryFormat(blocks[i]);
            }

            return blocks;
        }

        //доводим строку до размера, чтобы делилась на sizeOfBlock
        private string StringToRightLength(string input)
        {
            while (((input.Length * charSize) % blockSize) != 0)
                input += "#";

            return input;
        }

        //перевод строки в двоичный формат
        private string StringToBinaryFormat(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                string char_binary = Convert.ToString(input[i], 2);

                while (char_binary.Length < charSize)
                    char_binary = "0" + char_binary;

                output += char_binary;
            }

            return output;
        }

        //XOR двух строк с двоичными данными
        private string XOR(string s1, string s2)
        {
            string result = "";

            for (int i = 0; i < s1.Length; i++)
            {
                bool a = Convert.ToBoolean(Convert.ToInt32(s1[i].ToString()));
                bool b = Convert.ToBoolean(Convert.ToInt32(s2[i].ToString()));

                if (a ^ b)
                    result += "1";
                else
                    result += "0";
            }
            return result;
        }

        //переводим строку с двоичными данными в символьный формат
        private string StringFromBinaryToNormalFormat(string input)
        {
            string output = "";

            while (input.Length > 0)
            {
                string char_binary = input.Substring(0, charSize);
                input = input.Remove(0, charSize);

                int a = 0;
                int degree = char_binary.Length - 1;

                foreach (char c in char_binary)
                    a += Convert.ToInt32(c.ToString()) * (int)Math.Pow(2, degree--);

                output += ((char)a).ToString();
            }

            return output;
        }
    }
}
