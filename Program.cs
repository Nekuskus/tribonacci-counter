using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Czas teraz to " + DateTime.Now);
            Console.WriteLine("Czy chciałbyś obliczyć ciag Fibonacciego czy Tribonacciego?");
            do
            {
                Console.WriteLine("//Mozliwe odpowiedzi: 2, 3");
                int branch = Convert.ToInt16(Console.ReadLine);
                if(branch == 2)
                {
                    Fibonacci();
                }
                else if(branch == 3)
                {
                    Tribonacci();
                }
                else
                {
                    Console.WriteLine($"Niepoprawna odpowiedz: {branch}");
                }
            } while (branch = null);
        }
        static bool Fibonacci()
        {

        }
        static bool Tribonacci()
        {

        }
    }
}