using System;
using System.Collections.Generic;

namespace Functions5
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 24;
            int m = 40;



            /*            foreach(int j in PrimeNumbers(n))
                        Console.Write(j + " ");

                        Console.WriteLine("\n");*/




            foreach (int j in DecompositionInPrimeNumbers(n))
                Console.Write(j + " ");

            foreach (int j in DecompositionInPrimeNumbers(m))
                Console.Write(j + " ");

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


        static int DuplicateInArray(int[] array)
        {

            int count = 1;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j + 1])
                        count = count + 1;
                }
                /*                Console.WriteLine("\t\n " + array[i] + "occurse" + count);
                                Console.ReadKey();*/
            }

            return count;
        }
    }
}




