using System;

namespace Lab3___Tema3
{
    /*Ex 3
Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul
    */

    class Program
    {
        static void CheckPerfectSquare (int checkNumber)
        {
            for (int iterator = 1; iterator <= checkNumber / 2; iterator++)
            {
                if (iterator * iterator == checkNumber)
                {
                    Console.WriteLine("Numarul {0} este patrat perfect. ", checkNumber);
                    break;
                } else if ((iterator * iterator != checkNumber) && (iterator == checkNumber / 2))
                {
                    Console.WriteLine("Numarul {0} nu este patrat perfect", checkNumber);
                }          
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar: ");
            int number = int.Parse(Console.ReadLine());

            CheckPerfectSquare(number);
        }
    }
}
