using System;
using System.Linq;

namespace Vernam
{
    class Program
    {
        public static string[] ConvertToUni(string text)
        {
            string tmp = "";
            string str = "";
            string[] result = new string[text.Length];
            for (int t = 0; t < text.Length; t++)
            { 
                foreach (char i in text.ToCharArray())
                {
                    tmp = Convert.ToString(i, 2);
                    while (tmp.Length < 8) //выравниваем по 8 бит
                        tmp = '0' + tmp;
                    str += tmp;
                }
                result[t] = str;
            }
            return result;
        }

            //string[] result = new string[text.Length];
            //for (int i = 0; i < text.Length; i++)
            //{ 
            //    result[i] = String.Format("{0:x2}", (uint)System.Convert.ToUInt32(text[i].ToString()));
            //}
            //return result;


        

        public static int[,] encoding(string[] text, string[] key)
        {
            
            int[,] t = new int[text.Length, 8];
            int[,] k = new int[text.Length, 8];
            int[,] res = new int[text.Length, 8];
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (text[i][j] == '1')
                        t[i, j] = 1;
                    else
                        t[i, j] = 0;
                }
            }
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (key[i][j] == '1')
                        k[i, j] = 1;
                    else
                        k[i, j] = 0;
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                    if (t[i,j] != k[i,j])
                        res[i,j] = 1;
                    else
                        res[i,j] = 0;
            }
            return res;
        }
        
        //public static string ConvertFromUni(string[] arr)
        //{
        //    string result = "";
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        result += Convert.ToString(arr[i], 2);
        //        //Console.WriteLine(result[i]);
        //    }
        //    return result;
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();

            Console.WriteLine("Введите ключ такой же длины: ");
            string key = Console.ReadLine();

            Console.WriteLine(encoding(ConvertToUni(text), ConvertToUni(key)));


            //var a = text.ToCharArray().Select(i => Convert.ToString(i, 2));
            //foreach (var ch in a)
            //    Console.WriteLine(ch);
            //Console.ReadLine();



        }
    }
}
