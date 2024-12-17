using System;

namespace Uppgift_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -1;
            while (number != 0)
            {
                Console.Write("Skriv in et heltal (0 för att avsluta): ");

               
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number != 0)
                    {
                        Console.WriteLine($"Du skrev in: {number}");
                    }
                    else
                    {
                        Console.WriteLine("Du skrev in 0. Programmet avslutas.");
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltig input. Skriv in ett giltigt heltal.");
                }
            }
        }
    }
}
