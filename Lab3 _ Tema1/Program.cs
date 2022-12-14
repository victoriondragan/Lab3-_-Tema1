using System;

namespace Lab3___Tema1
{
    class Program
    {
        /*Ex 5
mănâncă toate clătitele începând de la a N-a clătită preparată, până
la a M-a clătită preparată(inclusiv N și M). 

 Dacă numărul de ordine al clătitei este prim atunci aceasta va fi cu ciocolată.
 Dacă numărul de ordine este pătrat perfect sau cub perfect aceasta va fi cu gem.
 Dacă suma divizorilor numărului este egală cu însuși numărul de ordine atunci aceasta va fi cu
înghețată. 
        (se iau în considerare toți divizorii în afară de numărul în sine, inclusiv 1).
 Dacă niciuna dintre condițiile de mai sus nu este îndeplinită, pentru cele cu numărul de ordine
par, clătita va fi cu zahar, iar pentru numărul de ordine impar, clătita va fi simplă.”
• Cerința

 Cunoscându-se N și M, numere naturale, să se determine câte clătite a mâncat Arpsod în total și
numărul de clătite din fiecare tip.A

• Indicii
1. iteratorul unui for nu incepe neaparat de la 1 ☺
2. folositi functii: extrageti operatiile
        */


        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti M: ");
            int numarM = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti N < M: ");
            int numarN = int.Parse(Console.ReadLine());

            int ordineMax = numarM - 1;

            int[] MC = new int[numarM];
            int[] MCOrdine = new int[ordineMax];


           
            static void CheckIfNumberIsPrime(int checkNumber)
            {
                for (int iterator = 2; iterator <= checkNumber / 2; iterator++)
                {
                    if (checkNumber % iterator == 0)
                    {
                        Console.WriteLine("Numarul nu este prim");
                        break;
                        //continue;
                    }
                    Console.WriteLine("Numarul este prim");
                    break;
                }
            }



            static void CheckPerfectSquare(int checkNumber)
            {
                for (int iterator = 1; iterator <= checkNumber / 2; iterator++)
                {
                    if (iterator * iterator == checkNumber)
                    {
                        string isSquare;
                        Console.WriteLine("Numarul {0} este patrat perfect. ", checkNumber);
                        break;
                    }
                    else if ((iterator * iterator != checkNumber) && (iterator == checkNumber / 2))
                    {
                        Console.WriteLine("Numarul {0} nu este patrat perfect. ", checkNumber);
                        break;
                    }
                }
            }



            static void CheckPerfectCube(int checkNumber)
            {
                for (int iterator = 1; iterator <= checkNumber / 2; iterator++)
                {                 
                    if (iterator * iterator * iterator == checkNumber)
                    {
                        string isCube;
                        Console.WriteLine("Numarul {0} este cub perfect. ", checkNumber);
                        break;
                    }
                    else if ((iterator * iterator * iterator != checkNumber) && (iterator == checkNumber / 2))
                    {                     
                        Console.WriteLine("Numarul {0} nu este cub perfect", checkNumber);
                        break;
                    }
                }
            }

            */


            static void DivisorsSum (int checkNumber)
            {
                for (int iterator = 1; iterator <= checkNumber - 1 / 2; iterator++)
                {
                    if (checkNumber % iterator == 0)
                    {

                        int sum = 0;
                        sum = sum + iterator;
                    }
                }
                Console.WriteLine(sum);
            }


            
            for (int i = 0; i <= (ordineMax); i++)
            {
                CheckIfNumberIsPrime(i);
                Console.WriteLine("clatita cu numarul de ordine a {0} este cu ciocolata / a {1} este numar prim", (i), (i));
                //  Dacă numărul de ordine este pătrat perfect sau cub perfect aceasta va fi cu gem.
                CheckPerfectSquare(i);
                Console.WriteLine("clatita cu numarul de ordine a {0} este cu gem / a {1} este patrat", (i), (i));
                CheckPerfectCube(i);
                Console.WriteLine("clatita cu numarul de ordine a {0} este cu gem / a {1} este cub", (i), (i));           
            }
            

        }
    }
}
