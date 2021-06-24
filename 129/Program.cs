using System;
using System.Collections.Generic;

namespace _129
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Największa i najmniejsza.");
            Console.WriteLine("Wprowadź serie liczb: ");

            List<int> tablica = new List<int>();
            int i = 1;
            while (true)
            {
                Console.Write($"Liczba = {i}. ");
                Console.Write("Wprowadź liczbę: ");
                tablica.Add(int.Parse(Console.ReadLine()));
                i++;
                if (tablica.Contains(-99))
                {
                    break;
                }
            }

            Console.WriteLine("--------------------");
            tablica.Remove(-99);
            int min = tablica[0];
            int max = tablica[0];
            foreach (var item in tablica)
            {
                if (item < min)
                {
                    min = item;
                }
                if (item > max)
                {
                    max = item;
                }

            }
            Console.WriteLine("Największa liczba to: " + max);
            Console.WriteLine("Najmniejsza liczba to: " + min);



            
            
        }
    }
}
