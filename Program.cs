using System;
using System.Collections.Generic;

namespace Program
{
    class Class
    {
        static string modify;
        static int branch;
        static int limit;
        static void Main(string[] args)
        {
            Console.WriteLine("Czas teraz to " + DateTime.Now);
            Console.WriteLine("Czy chciałbyś obliczyć ciag Fibonacciego czy Tribonacciego?");
            do
            {
                Console.WriteLine("//Mozliwe odpowiedzi: 2, 3");
                branch = Convert.ToInt32(Console.ReadLine());
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
            List<int> ciag = new List<int>();
            Console.WriteLine("Czy zmodyfikować pierwsze dwie liczby?\n(Eksperymentalne)");
            do
            {
                Console.WriteLine("//Mozliwe odpowiedzi: Tak, Nie");
                modify = Console.ReadLine();
                if(modify == "Tak")
                {
                    //tekst
                    ciag[0]= Convert.ToInt32(Console.ReadLine());
                    //tekst
                    ciag[1] = Convert.ToInt32(Console.ReadLine());
                }
                else if(modify == "Nie")
                {
                    ciag[0] = 0;
                    ciag[1] = 1;
                }
                else
                {
                    Console.WriteLine($"Niepoprawna odpowiedz: {modify}");
                }
            } while ((modify != "Nie") || (modify != "Tak"));
            Console.WriteLine("Do ktorej liczby wyliczac ciag?");
            limit = Convert.ToInt32(Console.ReadLine());
            /*for(i = 0; i <= limit; i++)
            {
                Console.Write($"{i+1} - {ciag[i]}");
                if(i>1)
                {
                    ciag.Add(ciag[i-1] + ciag[i-2]);
                }
            }*/
            
            foreach(var item in ciag)
            {
                Console.Write($"{ciag[ciag.IndexOf(item)]} - {item}");
                if(ciag.IndexOf(item)>1)
                {
                    ciag.Add(ciag[ciag.IndexOf(item)-1] + ciag[ciag.IndexOf(item)-2]);
                }
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