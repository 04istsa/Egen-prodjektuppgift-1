using System;

namespace Egen_prodjektuppgift__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //Console.WriteLine("Hello World!");
            // Console.WriteLine("Hej du ska gissa på ett tal mellan ett och tio");

            String choseNum = "0";

            while (choseNum != "3") 
            {
            
            
            Console.WriteLine("Välkommen till gissanumret");
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Vill du spela spelet");
            Console.WriteLine("2. Spelets regler");
            Console.WriteLine("3. Vill du avsluta spelet");
            int randNum = rand.Next(1, 11);
            
            choseNum = Console.ReadLine();
                Console.WriteLine();
            
            switch (choseNum)
            {

                case "1":
                        Console.WriteLine("Skriv ett tal mellan ett och tio");
                    int num = int.Parse(Console.ReadLine());
                    while (num != randNum )
                    {
                            if (num > 10)
                            {
                                Console.WriteLine("Du valde inte ett korrect alternativ");

                            }
                        if (num < randNum)
                        {
                            Console.WriteLine("Du gissade för för lågt");
                            Console.WriteLine("Gissa igen");
                            num = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Du gissade för högt");
                            Console.WriteLine("Gissa igen");
                            

                            

                        }

                    }
                    Console.WriteLine("Du vann");
                    break;
                case "2":

                    Console.WriteLine("Spelet går ut på att gissa på ett numer mellan ett och tio");
                    Console.WriteLine("Om du får fel berättar datorn om ditt tal är för högt eller för lågt");
                    Console.WriteLine("Där efter får du gissa igen tills du gissar rätt");
                        Console.WriteLine();
                    break;

                case "3":
                    break;











                    /* int randNum = rand.Next(1, 11);
                    Console.WriteLine();




                    int gues = int.Parse(Console.ReadLine());
                    if (gues == randNum)
                    {
                        Console.WriteLine("Grattis du gissad rätt");
                    }
                   else  
                    {


                    }
                    */

                    /*else
                    {
                        Console.WriteLine("Du gissade för lågt");
                    }
                    */

              
                } 
             }
        }
    }
}
