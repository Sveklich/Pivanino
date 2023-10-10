namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Piano = new int[] { };
            ConsoleKeyInfo pkey = Console.ReadKey();
            Piano = Octave1();
            Console.WriteLine("3 Октава");
            while (pkey.Key != ConsoleKey.Escape)
            {
                pkey = Console.ReadKey();
                if (pkey.Key == ConsoleKey.F1)
                {
                    Piano = Octave1();
                    Console.WriteLine("3 Октава");
                }
                else if (pkey.Key == ConsoleKey.F2)
                {
                    Piano = Octave2();
                    Console.WriteLine("4 Октава");
                }
                else if (pkey.Key == ConsoleKey.F3)
                {
                    Piano = Octave3();
                    Console.WriteLine("5 Октава");
                }
                else if (pkey.Key == ConsoleKey.D)
                {
                    Console.Beep(Piano[0], 100);
                }
                else if (pkey.Key == ConsoleKey.R)
                {
                    Console.Beep(Piano[1], 100);
                }
                else if (pkey.Key == ConsoleKey.F)
                {
                    Console.Beep(Piano[2], 100);
                }
                else if (pkey.Key == ConsoleKey.Y)
                {
                    Console.Beep(Piano[3], 100);
                }
                else if (pkey.Key == ConsoleKey.G)
                {
                    Console.Beep(Piano[4], 100);
                }
                else if (pkey.Key == ConsoleKey.H)
                {
                    Console.Beep(Piano[5], 100);
                }
                else if (pkey.Key == ConsoleKey.U)
                {
                    Console.Beep(Piano[6], 100);
                }
                else if (pkey.Key == ConsoleKey.J)
                {
                    Console.Beep(Piano[7], 100);
                }
                else if (pkey.Key == ConsoleKey.I)
                {
                    Console.Beep(Piano[8], 100);
                }
                else if (pkey.Key == ConsoleKey.K)
                {
                    Console.Beep(Piano[9], 100);
                }
                else if (pkey.Key == ConsoleKey.O)
                {
                    Console.Beep(Piano[10], 100);
                }
                else if (pkey.Key == ConsoleKey.L)
                {
                    Console.Beep(Piano[11], 100);
                }

            }
            static int[] Octave1()
            {
                int[] Octave = new int[12] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247};
                return Octave;
            }
            static int[] Octave2()
            {
                int[] Octave = new int[12] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
                return Octave;
            }
            static int[] Octave3()
            {
                int[] Octave = new int[12] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
                return Octave;
            }
        }
    }
}