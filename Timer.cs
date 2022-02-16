using System;
using System.Threading;
namespace StopWatch
{
    class Timer
    {
        public static void Menu()
        {
            Console.WriteLine("Bem vindos ao StopWatch!!");
            Console.WriteLine("S - Segundos => 10s = 10 Segundos");
            Console.WriteLine("M - Minutos => 1m = 1 minuto");
            Console.WriteLine("0 - Para Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            var data = Console.ReadLine().ToLower();

            var type = char.Parse(data.Substring(data.Length - 1, 1));
            var time = int.Parse(data.Substring(0, data.Length - 1));

            if (time == 0)
            {
                Console.WriteLine("Finalizando Programa");
                Environment.Exit(0);
            }

            switch (type)
            {
                case 'm': PreStart(time * 60); break;
                case 's': PreStart(time); break;
                default: Menu(); break;
            }


        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Goooo!");
            Thread.Sleep(1000);

            Start(time);

        }
        static void Start(int time)
        {

            var currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finished... returning to menu");
            Thread.Sleep(2500);
            Menu();
        }
    }
}