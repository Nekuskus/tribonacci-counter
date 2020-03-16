using System;
using System.Collections.Generic;

namespace Program
{
    class Class
    {
        static string modify;
        static long branch;
        static long limit;
        static void Main(string[] args)
        {
            Console.WriteLine("Czas teraz to " + DateTime.Now);
            Console.WriteLine("Czy chciałbyś obliczyć ciag Fibonacciego czy Tribonacciego?");
            do
            {
                Console.WriteLine("//Mozliwe odpowiedzi: 2, 3");
                branch = Convert.ToInt64(Console.ReadLine());
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
            } while ((branch != 2) || (branch != 3));
        }
        static bool Fibonacci()
        {
            List<long> ciag = new List<long>();
            Console.WriteLine("Czy zmodyfikować pierwsze dwie liczby?\n(Eksperymentalne)");
            do
            {
                Console.WriteLine("//Mozliwe odpowiedzi: Tak, Nie");
                modify = Console.ReadLine();
                if(modify == "Tak")
                {
                    Console.WriteLine("Czym zastapic pierwsza liczbe?");
                    ciag.Add(Convert.ToInt64(Console.ReadLine()));
                    Console.WriteLine("Czym zastapic druga liczbe?");
                    ciag.Add(Convert.ToInt64(Console.ReadLine()));
                    continue;
                }
                else if(modify == "Nie")
                {
                    ciag.Add(0);
                    ciag.Add(1);
                    continue;
                }
                else
                {
                    Console.WriteLine($"Niepoprawna odpowiedz: {modify}");
                }
            } while (ciag.Count != 2);
            Console.WriteLine("Do ktorej liczby wyliczac ciag?");
            limit = Convert.ToInt64(Console.ReadLine());
            /*for(i = 0; i <= limit; i++)
            {
                Console.Write($"{i+1} - {ciag[i]}");
                if(i>1)
                {
                    ciag.Add(ciag[i-1] + ciag[i-2]);
                }
            }*/
            int i = 0;
            for(i = 2; i <= limit; i++)
            {
                ciag.Add(ciag[i-1] + ciag[i-2]);
            }
            foreach(var item in ciag)
            {
                Console.WriteLine($"{ciag.IndexOf(item)} - {item}");
            }
            return true;
        }
        static bool Tribonacci()
        {
            return true;
        }
    }
}