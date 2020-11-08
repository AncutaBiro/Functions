/*
 Se dă un șir de numere pe o singură linie, despărțite între ele printr-un spațiu.
Apoi, cât timp utilizatorul nu introduce tasta "x", se citește căte o linie de la tastatură. Linia conține un index și o valoare despărțite între ele printr-un spațiu, iar aplicația va seta valoarea specificată la indexul specificat în șirul de numere inițial.

La sfârșit se afișează șirul de numere modificat corespunzător, pe o singură linie.

Exemplu:

Pentru datele de intrare:

1 2 3 4 5 6 7 8 9
0 9
1 9
2 9
6 0
7 0
8 0
x
La consolă se va afișa:

9 9 9 4 5 6 0 0 0
 */

using System;

namespace SetValueAtIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valuesList = ReadValuesList();

            string line = Console.ReadLine();

            while (line != "x")
            {
                string[] lineItems = line.Split(' ');
                int index = Convert.ToInt32(lineItems[0]);
                int value = Convert.ToInt32(lineItems[1]);
                UpdateValue(valuesList, index, value);
                line = Console.ReadLine();
            }

            PrintValuesList(valuesList);
            Console.Read();
        }

        static void UpdateValue(int[] valuesList, int index, int value)
        {
            for (int i = 0; i < valuesList.Length; i++)
            {
                valuesList[index] = value;
            }
        }

        static void PrintValuesList(int[] valuesList)
        {
            for (int i = 0; i < valuesList.Length; i++)
                Console.Write(valuesList[i] + " ");
        }

        static int[] ReadValuesList()
        {
            string[] inputValues = Console.ReadLine().Split(' ');
            int[] values = new int[inputValues.Length];

            for (int i = 0; i < values.Length; i++)
                values[i] = Convert.ToInt32(inputValues[i]);

            return values;
        }
    }
}
