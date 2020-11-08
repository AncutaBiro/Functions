/*
Se dă un text pe o linie urmat de N operații de inversare de caractere, fiecare pe câte o linie, în următorul format: index1, un spațiu, index2.
Fiecare operație de inversare aplicată pe textul primit înseamnă inversarea între ele a caracterelor de la index1 și index2.

Să se tipărească la consolă textul modificat după ce s-au aplicat toate operațiile de inversare de caractere.

Exemplu:

Pentru datele de intrare:
un nou test
3
0 1
2 3
1 2
La consolă se va afișa:
nnu ou test
 
 */

using System;

namespace StringSwaps
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialText = Console.ReadLine();
            ReadSwaps(out int[] firstIndex, out int[] secondIndex);

            string updatedText = initialText;

            for (int i = 0; i < firstIndex.Length; i++)
                updatedText = ApplySwap(updatedText, firstIndex[i], secondIndex[i]);

            Console.WriteLine(updatedText);
            Console.Read();
        }

        static string ApplySwap(string text, int firstIndex, int secondIndex)
        {
               char[] textArray = text.ToCharArray();

               char temp = textArray[firstIndex];
               textArray[firstIndex] = textArray[secondIndex];
               textArray[secondIndex] = temp;

               return new string (textArray);
        }

        static void ReadSwaps(out int[] firstIndex, out int[] secondIndex)
        {
            int swapsNumber = Convert.ToInt32(Console.ReadLine());
            firstIndex = new int[swapsNumber];
            secondIndex = new int[swapsNumber];

            for (int i = 0; i < swapsNumber; i++)
            {
                string[] swapInfo = Console.ReadLine().Split(' ');
                firstIndex[i] = Convert.ToInt32(swapInfo[0]);
                secondIndex[i] = Convert.ToInt32(swapInfo[1]);
            }
        }

    }
}

