using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract8
{
    internal class p
    {
        public static Random rnd = new Random();
        public static List<string> texti = new();
        public static string[] words;
        public static int i = 0;
        public static int j = 0;
        public static int position = 3;
        public static string vibor;

        public static void listik()
        {
            string text = "И.";
            string text2 = "Т";
            string text3 = "В";
            texti.Add(text);
            texti.Add(text2);
            texti.Add(text3);
            vibor = texti[rnd.Next(0, texti.Count)];
            words = vibor.Split(" ");
            int kkk = 0;

            Console.Clear();
            while (j != words.Count())
            {



                foreach (string s in words)
                {
                    Console.Write(s + " ");
                    j++;
                    kkk++;


                    if (kkk == 10)
                    {
                        kkk = 0;
                        Console.WriteLine("");
                        position++;
                    }


                }
                Console.WriteLine("");
                position++;


            };

        }
        /* public static void vivod(List<string> bukvi)
         {


         }*/
    }
}
