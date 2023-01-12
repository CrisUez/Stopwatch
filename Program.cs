using System;
using System.Threading;

namespace Stopwatch
{

    class Program
    {
        static void Main(string[] args)
        {

            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 Segundos");
            Console.WriteLine("M = Minuto => 1m = 60 segundos ");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar ?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse((data.Substring(0, data.Length - 1)));
            int multiplier = 1;
            Console.WriteLine(data);

            if (type == 'm')
            {
                multiplier = 60;
            }

            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar ...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar ...");
            Thread.Sleep(1000);
            Console.WriteLine("Fogo!");
            Thread.Sleep(2500);

            Start(time);


        }

        static void Start(int time)
        {

            int currenTime = 0;

            while (currenTime != time)
            {
                Console.Clear();
                currenTime++;
                Console.WriteLine(currenTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}



