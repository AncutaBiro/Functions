/*
La un concurs de cunoștințe generale se pornește cu o sumă de bani dată inițial și apoi concurenții trebuie să răspundă corect la 9 întrebări. Fiecare răspuns corect dublează suma câștigată, exceptând răspunsurile la întrebările 3, 6 și 9 care triplează suma.

Scrie o aplicație ce primește suma inițială și numărul de răspunsuri corecte date de un concurent și afișează suma totală câștigată de acel concurent.

Exemplu:

Pentru datele de intrare:

3
9
La consolă se va afișa:

5184
 */

using System;

namespace KnowledgeContest
{
    class Program
    {
        static void Main(string[] args)
        {
            long initialAmount = Convert.ToInt64(Console.ReadLine());
            int questionsAnswered = Convert.ToInt32(Console.ReadLine());

            long amountEarned = initialAmount;
            for (int i = 1; i <= questionsAnswered; i++)
            {
                if (i % 3 != 0)
                {
                    Multiply(ref amountEarned);
                }
                else
                {
                    Multiply(ref amountEarned, 3);
                }

            }

            Console.WriteLine(amountEarned);
            Console.Read();
        }

        static void Multiply(ref long baseValue, int multiplier = 2)
        {
            baseValue = baseValue * multiplier;
        }
    }
}
