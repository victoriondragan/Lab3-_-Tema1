using System;

namespace Lab3___Tema4
{
    /*
     Ex 4
Se citeste de la tastatura un vector continand n numere intregi, n fiind si el citit de la tastatura. Scrieti functii care vor returna
• Cel mai mare numar din vector
• Cel mai mic numar din vector
• Numerele divizibile cu 3
Dificultate ridicata
• Numerele prime din vector
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n - numarul numerelor din vector.");
            int numarulMembrilorSirului = int.Parse(Console.ReadLine());

            int[] arrayNumbers = new int[numarulMembrilorSirului];

            Console.WriteLine("Introduceti {0} numere: ", numarulMembrilorSirului);

            for (int i = 0; i < numarulMembrilorSirului; i++)
            {
                arrayNumbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sirul este format din: [{0}]", string.Join(", ", arrayNumbers));

            int largestNumber = 0;

            for (int j = 0; j <= numarulMembrilorSirului - 1; j++)
            {
                if ((arrayNumbers[j] > largestNumber))
                {
                    largestNumber = arrayNumbers[j];                 
                }
                if (j == numarulMembrilorSirului - 1)
                    Console.WriteLine("cel mai mare nr din sir este {0} ", largestNumber);
            }


            
            int smallerNumber = 0;
            for (int j = 0; j <= numarulMembrilorSirului - 1; j++)
            {
                if ((arrayNumbers[j] < largestNumber))
                {
                    smallerNumber = arrayNumbers[j];
                }

                if (arrayNumbers[j] < smallerNumber)
                {
                    smallerNumber = arrayNumbers[j]; 
                }

                if (j == numarulMembrilorSirului - 1)
                    Console.WriteLine("cel mai mic nr din sir este {0} ", smallerNumber);
            }
            

            
            int divisibleWith_3 = 3;
            for (int j = 0; j <= numarulMembrilorSirului - 1; j++)
            {               
                if (arrayNumbers[j] % 3 == 0)
                {
                    divisibleWith_3 = arrayNumbers[j];                   
                    int div3Contor = 0;                   
                    div3Contor++;
                    int[] numbersDivisibleWith_3 = new int[div3Contor];
                    Console.WriteLine("Sirul numerelor divizibile cu 3 este format din: [{0}]", string.Join(", ", numbersDivisibleWith_3));
                }
            }
        }
    }
}
