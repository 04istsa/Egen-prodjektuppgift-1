using System;

namespace Egen_prodjektuppgift__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hej duska gissa på ett tal mellan ett och tio");
            int gues = int.Parse(Console.ReadLine());
            int randNum = rand.Next(1, 11);
            
            if (gues == randNum)
            {
                Console.WriteLine("Grattis du gissad rätt");
            } else 
            { 

            while(gues != randNum)
            {

            }
            
            }
        }
    }
}
