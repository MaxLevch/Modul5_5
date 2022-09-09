namespace modul5_5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень");
            byte Pow = byte.Parse(Console.ReadLine());

            int result = PowerUp(x, Pow);
            Console.WriteLine("{0} в степени {1} = {2}", x, Pow, result);
            //    //Console.WriteLine("Напишите что-то");
                //var str = Console.ReadLine();

                //Console.WriteLine("Укажите глубину эха");
                //var deep = int.Parse(Console.ReadLine());

                //Echo(str, deep);

                //Console.ReadKey();
        }

        static decimal Factorial(int x)
        {
            if (x == 0) { return 1; }
            else { return x * Factorial(x - 1); }
        }

        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1) { return N; }
                else
                {
                    pow--;
                    return N * PowerUp(N, pow);
                }
            }
        }
        static void Echo(string saidworld, int deep)
        {
            switch (deep)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }
            var modif = saidworld;
            if (modif.Length>2)
            {
                modif = modif.Remove(0, 2);
                Console.WriteLine("..." + modif);
            }
           
            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
    }
}     