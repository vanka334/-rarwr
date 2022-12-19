using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract8
{
    internal class Timer
    {
        int i = 0;
        public static void timer()
        {
            
            Thread time = new Thread(_ =>
            {
                while (GorR.wordCount != p.words.Count())
                {
                    Program.timer+= 1;
                    Console.SetCursorPosition(0,(p.position)+1);
                    Console.WriteLine(Program.timer);

                    Thread.Sleep(1000);
                }

            });
            time.Start();
        }
    }
}
