using System;
using System.Collections.Generic;

/*
 https://www.examenultau.ro/blog/cel-mai-mare-divizor-comun/
https://www.geeksforgeeks.org/program-to-find-lcm-of-two-numbers/
pas cu pas pentru a afla lcm cmmmc
 */

namespace Functions5
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 84;
            int m = 196;

            int[] decompositionA = DecompositionInPrimeNumbers(n);
            int[] decompositionB = DecompositionInPrimeNumbers(m);

            /*List<int> a = new List<int> {2,2,3,7,5};
            List<int> b = new List<int> {2,7,2,5};

            foreach (int k in Find (a, b))
                Console.Write(k + " ");*/

            Console.WriteLine();


            foreach (int j in decompositionA)
                Console.Write(j + " ");

            Console.WriteLine();

            OccurencesOfElementInArray(decompositionA);


            foreach (int j in decompositionB)
                Console.Write(j + " ");

            Console.WriteLine();

            foreach (int k in FindCommonElements(decompositionA, decompositionB))
            Console.Write(k);



        }







        static int[] PrimeNumbers(int number)
        {

            List<int> primeNumbers = new List<int>();

            for (int j = 2; j <= number; j++)
            {
                bool x = true;

                for (int i = 2; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        x = false;
                    }
                }

                if (x)
                {
                    primeNumbers.Add(j);
                }
            }

            return primeNumbers.ToArray();

        }


        static int[] DecompositionInPrimeNumbers(int n)

        {
            int[] primeNumbersList = PrimeNumbers(n);

            List<int> nDescompositionList = new List<int>();

            for (int i = 0; i < primeNumbersList.Length;)
            {
                if (n % primeNumbersList[i] == 0)
                {

                    nDescompositionList.Add(primeNumbersList[i]);
                    n = n / primeNumbersList[i];
                }

                else
                {
                    i++;
                }

            }
            return nDescompositionList.ToArray();
        }


        static int OccurencesOfElementInArray(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                count = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        count = count + 1;
                }

                Console.WriteLine(array[i] + "occurs" + count + "times");
            }

            return count;
        }

/*
        int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
for (int i = 0; i<array.Length; i++)
{
    int count = 0;
    for (int j = 0; j<array.Length ; j++)
    {
       if(array[i] == array[j])
          count = count + 1;
    }
    Console.WriteLine("\t\n " + array[i] + " occurs " + count);
    Console.ReadKey();*/





static int[] FindCommonElements(int[] a1, int[] a2)
        {
            int count = 0;

            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a2.Length; j++)
                {
                    if (a1[i] == a2[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            int[] result = new int[count];

            count = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a2.Length; j++)
                {
                    if (a1[i] == a2[j])
                    {
                        result[count++] = a1[i];
                        break;
                    }
                }
            }

            return result;
        }



        static List<int> Find(List <int> a1, List <int> a2) 
       
        {

            List<int> c = new List<int>();

            foreach (int a in a1)
            {
                if (a2.Contains(a))

                    c.Add(a);
            }

            for (int i = 0; i < c.Count; i++)
            {
                for (int j = i; j < c.Count-1; j++)
                {
                    if (c[i] == c[j])
                    {
                        c.Remove(c[i]);
                
                    }
                }
            }

            return c;
        }
    }
}




