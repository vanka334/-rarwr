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
            string text = "И они деликатно намекнули профеcсору Ивановскому, что его зять Хаим Ягудин – заслуженный унтер-офицер, инвалид, ходить ему трудно, и хорошо бы профессору его навестить, тем более муж его покойной сестры и до дома Хаима всего пятьсот шагов.";
            string text2 = "Так называ аналитические способности нашего ума сами по себе мало доступны анализу. Мы судим о них только по результатам. Среди прочего нам известно, что для человека, особенно одаренного в этом смысле, дар анализа служит источником живейшего наслаждения.Подобно тому как атлет гордится своей силой и ловкостью и находит удовольствие в упражнениях, заставляющих его мышцы работать, так аналитик радуется любой возможности что-то прояснить или распутать. Всякая, хотя бы и нехитрая задача, высекающая искры из его таланта, ему приятна. Он обожает загадки, ребусы и криптограммы, обнаруживая в их решении проницательность, которая уму заурядному представляется чуть ли не сверхъестественной.";
            string text3 = "В холодное осеннее ненастье, на одной из больших тульских дорог, залитой дождями и изрезанной многими черными колеями, к длинной избе, в одной связи которой была казенная почтовая станция, а в другой частная горница, где можно было отдохнуть или переночевать, пообедать или спросить самовар, подкатил закиданный грязью тарантас с полуподнятым верхом, тройка довольно простых лошадей с подвязанными от слякоти хвостами. ";
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
