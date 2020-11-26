using System;

namespace Functions6._1
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
                    DecimalProbability(n, k, k - 0);
                    break;
                case "II":
                    DecimalProbability(n, k, k - 1);
                    break;
                case "III":
                    DecimalProbability(n, k, k - 2);
                    break;
            }
        }
            static void DecimalProbability(int n, int k, int c)
            {

            double x = bc(k, c) * bc(n - k, k - c) / bc(n, k);

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("0.0000000000"));

            }

            static double bc (double n, double k)
            {
                if (k == 0 || k == n)
                    return 1;
                return bc(n - 1, k - 1) + bc(n - 1, k);
            }

        }
    }
