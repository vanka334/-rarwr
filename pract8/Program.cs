using System.IO.Pipes;
using System.Text;

namespace pract8
{
    internal class Program
    {
        public static List<Tablica> list = new List<Tablica>();
        public static string name;
        public static int err = 0;
        public static double timer = 0;
        public static ConsoleKeyInfo key;
        static void Main()
        {
            Console.WriteLine("Нажмите любую клавишу чтобы начать программу");
             key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Тест на скорость печати \n Чтобы посмотреть таблицу рекордов нажмите - F10 | Для начала нажмите - F11 \n-------------------------------------------------------");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("Введите имя");
                    name = Console.ReadLine();

                    p.listik();
                    Timer.timer();
                        GorR.Reading();
                    Console.ReadKey();
                }
                else if (key.Key == ConsoleKey.F10)
                {
                    Ser.Deserialize();
                    foreach (Tablica c in list)
                    {
                        Console.WriteLine("Имя: "+c.nameid + "       Время: "+ c.time + "       Ошибки: "+ c.errors);


                    }
                    if (list.Count == 0)
                    {
                        Console.WriteLine("Нет никого(");


                    };
                    Console.ReadKey();

                }
                Tablica person = new(name, timer, err);
                list.Add(person);
                
                Ser.Serelization(list);

            }


        }
    }
}