/*
Se citește de la tastatură o dată calendaristică în următorul format:

ziua pe prima linie
luna în format numeric pe linia 2 (de la 1 la 12)
anul pe următoarea linie
Pe următoarea linie e o opțiune ce indică formatul în care vrem să tipărim data citită. Există 3 variante:

opțiunea 1: se afișează ziua + spațiu + luna în format text (de exemplu: 1 iunie)
opțiunea 2: se afișează luna în format text + spațiu + anul (de exemplu: iunie 2017)
opțiunea 3: se afișează ziua + spațiu + luna în format text + spațiu + anul (de exemplu: 1 iunie 2017)
Exemplu:

Pentru datele de intrare:

1
6
2017
3
La consolă se va afișa:

1 iunie 2017
 
 */


using System;

namespace Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "ianuarie", "februarie", "martie", "aprilie", "mai", "iunie",
                "iulie", "august", "septembrie", "octombrie", "noiembrie", "decembrie"};

            string day = Console.ReadLine();
            string month = months[Convert.ToInt32(Console.ReadLine()) - 1];
            string year = Console.ReadLine();

            PrintDate(day, month, year, Console.ReadLine());
            Console.Read(); ;
        }

        static void PrintDate(string day, string month, string year, string option)
        {

            switch (option)
            {
                case "1":
                    Console.WriteLine(Concat(day, month));
                    break;
                case "2":
                    Console.WriteLine(Concat(month, year));
                    break;
                case "3":
                    Console.WriteLine(Concat(day, month, year));
                    break;
            }

        }

        static string Concat(params string[] words)
        {
            string result = "";

            foreach (string s in words)
            {
                result += s + " ";
            }

            return result;
        }
    }
}
