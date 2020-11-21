using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash
{
    public partial class Form1 : Form
    {
        private const int blockSize = 64; //размер блока 32 бит(в unicode символ в два раза длинее)
        private const int charSize = 16;
        private const int shiftKey = 2; //сдвиг ключа 
        private const int countRounds = 16; //количество раундов
        //string[] desBlocks; //блоки в двоичном формате


        private const int passBlockSize = 64; //размер блока 16 бит(в unicode символ в два раза длинее)
        //string[] passBlocks; //блоки в двоичном формате


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = passwordBox.Text;

            pass = StringToRightLength(pass);

            string[] passBlocks = CutPassToBlocks(pass);

            pass = StringToBinaryFormat(pass);


            List<string> h = new List<string>();
            h.Add("0000000000000000000000000000000000000000000000000000000000000000");

            for(int i = 0; i < (pass.Length / passBlockSize); i++)
            {
                string enc = (EnCrypt(h[i], passBlocks[i]));

                string newH = XOR(h[i], enc);

                h.Add(newH);
            }

            hashBox.Text = StringFromBinaryToNormalFormat(h[h.Count - 1]);
        }

        public string EnCrypt(string X, string key)
        {
            X = StringToRightLength(X);

            string[] desBlocks = CutBinaryStringIntoBlocks(X);

            //key = CorrectKeyWord(key, blockSize / charSize);

            //key = StringToBinaryFormat(key);

            //сеть фейстеля
            for (int j = 0; j < countRounds; j++)
            {
                for (int i = 0; i < desBlocks.Length; i++)
                    desBlocks[i] = EncodeRound(desBlocks[i], key);

                key = KeyToNextRound(key);
            }

            string result = "";

            for (int i = 0; i < desBlocks.Length; i++)
                result += desBlocks[i];

            return result;
        }

        //доводим строку до размера, чтобы делилась на sizeOfBlock
        private string StringToRightLength(string input)
        {
            while (((input.Length * charSize) % blockSize) != 0)
                input += "#";

            return input;
        }

        //разбиение строки на блоки
        private string[] CutStringToBlocks(string input)
        {
            string [] blocks = new string[(input.Length * charSize) / blockSize];

            int lengthOfBlock = input.Length / blocks.Length;

            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = input.Substring(i * lengthOfBlock, lengthOfBlock);
                blocks[i] = StringToBinaryFormat(blocks[i]);
            }

            return blocks;
        } 
        //разбиение двоичной строки на блоки
        private string[] CutBinaryStringIntoBlocks(string input)
        {
            string[] blocks = new string[input.Length / blockSize];

            int lengthOfBlock = input.Length / blocks.Length;

            for (int i = 0; i < blocks.Length; i++)
                blocks[i] = input.Substring(i * lengthOfBlock, lengthOfBlock);

            return blocks;
        }

        //разбиение пароля на блоки
        private string[] CutPassToBlocks(string input)
        {
            string[] blocks = new string[(input.Length * charSize) / passBlockSize];

            int lengthOfBlock = input.Length / blocks.Length;

            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = input.Substring(i * lengthOfBlock, lengthOfBlock);
                blocks[i] = StringToBinaryFormat(blocks[i]);
            }

            return blocks;
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

        //доводим длину ключа до нужной
        private string CorrectKeyWord(string input, int lengthKey)
        {
            if (input.Length > lengthKey)
                input = input.Substring(0, lengthKey);
            else
                while (input.Length < lengthKey)
                    input = "0" + input;

            return input;
        }

        //шифрование DES один раунд
        private string EncodeRound(string input, string key)
        {
            string L = input.Substring(0, input.Length / 2);
            string R = input.Substring(input.Length / 2, input.Length / 2);

            return (R + XOR(L, f(R, key)));
        }

        //расшифровка DES один раунд
        private string DecodeRound(string input, string key)
        {
            string L = input.Substring(0, input.Length / 2);
            string R = input.Substring(input.Length / 2, input.Length / 2);

            return (XOR(f(L, key), R) + L);
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

        //шифрующая функция f. в данном случае это XOR
        private string f(string s1, string s2)
        {
            return XOR(s1, s2);
        }

        //вычисление ключа для следующего раунда шифрования. циклический сдвиг >> 2
        private string KeyToNextRound(string key)
        {
            for (int i = 0; i < shiftKey; i++)
            {
                key = key[key.Length - 1] + key;
                key = key.Remove(key.Length - 1);
            }

            return key;
        }

        //вычисление ключа для следующего раунда расшифровки. циклический сдвиг << 2
        private string KeyToPrevRound(string key)
        {
            for (int i = 0; i < shiftKey; i++)
            {
                key = key + key[0];
                key = key.Remove(0, 1);
            }

            return key;
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

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true ? passwordBox.Text.Length >= 4 : button1.Enabled = false;
        }
    }
}
