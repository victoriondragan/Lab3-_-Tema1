using System;

namespace Lab3___Tema2
{
    class Program
    {
        /*
         Ex 2
Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati-o si afisati-i rezultatul
        */  


        static void CheckIfNumberIsPrime(int primeCheck)
        {         
            for (int iterator = 2; iterator <= primeCheck / 2; iterator++)
            {
                if (primeCheck % iterator == 0)
                {
                  
                    Console.WriteLine("Numarul nu este prim");
                    break;
                    //continue;
                }
                Console.WriteLine("Numarul este prim");
                break;
            }
        }

       



        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg: ");
            int number = int.Parse(Console.ReadLine());
            CheckIfNumberIsPrime(number);
        }
    }
}
