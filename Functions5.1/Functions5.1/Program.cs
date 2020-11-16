/*
Se dau două numere întregi pozitive diferite. Să se afișeze pe căte o linie cel mai mare divizor comun (cmmdc) și cel mai mic multiplu comun (cmmmc) a celor două numere.
Exemplu:
Pentru datele de intrare:
6
4
La consolă se va afișa:

2
12
 
 */

using System;

namespace Functions5._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Cmmdc(a, b));
            Console.WriteLine(Cmmmc(a, b));
        }

        static int Minimum(int a, int b)
        {
            {
                int min = a < b ? a : b;

                return min;
            }
        }

        /*initialize cmmdc with 1 in case of 2 prime number that will both only by 1. 
         * The smallest cmmdc is 2, so starting from 2 until the min (a, b) check each number that will divide both numbers without a reminder => finding the greatest common factor */
        static int Cmmdc(int a, int b)
        {
            int cmmdc = 1;

            int min = Minimum(a, b);

            for (int i = 2; i <= min; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    cmmdc = i;
                }
            }
            return cmmdc;

        }

        /* extract cmmmc after formula  a * b = LCM(a, b) * GCD(a, b) */

        static int Cmmmc(int a, int b)
        {
            int p = a * b;

            return p / Cmmdc(a, b);

        }

    }
}

