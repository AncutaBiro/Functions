﻿/*
 Vrei să participi la jocul de noroc 6 din 49 cu o singură variantă (simplă) și vrei să știi ce șanse ai să câștigi:

la categoria I (6 numere)
la categoria II (5 numere)
la categoria III (4 numere)
Scrie o aplicație consolă ce calculează șansele de câștig la loto. Generalizează soluția să funcționeze pentru orice combinație de bile totale, bile extrase și categorie.

Aplicația primește ca date de intrare numărul total de bile, numărul de bile extrase și categoria și apoi tipărește șansele de câștig cu o precizie de 10 zecimale dacă se joacă cu o singură variantă.

Exemplu:

Pentru datele de intrare:

40
5
II
La consolă se va afișa:

0.0002659542

Sursa pt formule aplicate: https://en.wikipedia.org/wiki/Lottery_mathematics

 */

using System;

namespace Functions6
{
    class Program
    {
        static void Main(string[] args)
        {
            // total number of balls
            int n = Convert.ToInt32(Console.ReadLine());
            // number of balls selected
            int k = Convert.ToInt32(Console.ReadLine());
            // category 
            string category = Console.ReadLine();

            switch (category)
            {
                case "I":
                    DecimalProbability(n, k, k);
                    Console.WriteLine(d);
                    break;
                case "II":
                    DecimalProbability(n, k, k);
                    break;
                case "III":
                    DecimalProbability(n, k, k);
                    break;
            }

            static decimal DecimalProbability(int n, int k, int c)
            {
                decimal x = Combinations(k, c) * Combinations(n - k, k - c) / Combinations(n, k);

                Console.WriteLine(x.ToString("0.0000000000"));

                return x;

            }

            static ulong Factorial(int x)

            {
                ulong product = 1;

                for (int i = 1; i <= x; i++)
                {
                    product *= (ulong)i;
                }

                return product;
            }

            static ulong FactorialTotalMinusSelected (int x, int y)

            {
                ulong product = 1;

                for (int i = x; i > x - y; i--)
                {
                    product *= (ulong)i;
                }

                return product;
            }


            static decimal Combinations(int x, int y)
            {
                ulong dividend = FactorialTotalMinusSelected (x, y);

                ulong divisor = Factorial(y);

                decimal d = (decimal) dividend / divisor;

                return d;
            }
    
        }

    }
}

