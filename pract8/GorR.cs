namespace pract8
{
    internal class GorR
    {
        public static char[] char_massive;
        public static int wordCount = 0;

        public static int old_position;



        public static void Reading()
        {

            foreach (string d in p.words)
            {
                char_massive = p.words[wordCount].ToCharArray();
                for (int i = 0; i < char_massive.Length; i++)
                {

                    Program.key = Console.ReadKey(true);
                    old_position++;

                    if (Program.key.Key == ConsoleKey.Backspace)
                    {
                        Console.SetCursorPosition(old_position - 1, p.position);
                        Console.Write(" ");
                        Console.SetCursorPosition(old_position - 1, p.position);
                        i = i - 1;
                        old_position--;
                        continue;


                    }
                    if (Program.key.Key == ConsoleKey.Spacebar)
                    {
                        Console.SetCursorPosition(0, p.position);
                        Console.Write("                               ");
                        Console.SetCursorPosition(0, p.position);
                        i--;
                        old_position = 0;
                        continue;
                    }


                    char input_char = Program.key.KeyChar;
                    Green_or_Red(char_massive[i], input_char);
                }
                wordCount++;
            }
        }
        public static void Green_or_Red(char c, char input_char)
        {
            if (c == input_char)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Program.err++;

            }
            Console.SetCursorPosition(old_position, p.position);
            Console.Write(input_char);


        }
    }
}
