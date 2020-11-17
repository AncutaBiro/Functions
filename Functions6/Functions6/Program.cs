using System;

namespace Functions6
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = 49;
            int e = 6;
            int c = 2;


            Console.WriteLine(Probability(t,e));
        }

            static int Factorial (int n)
            
            {
            int product = 1;

            for (int i= 1; i <=n; i++) 
            {
                product *= i;
            }

            return product;
            }

        static string Probability (int t, int e) {

            double p = 1;
            int i = 6;
            int j;

           while (i > 0) { 
            
            for (j = 49; j >= 49 -(i-1); j--) 
                {
                    p *= (double) i/j;
                    i--;
                }
            }

            return p.ToString("0.0000000000");


/*            ulong p = (ulong)(Factorial(t) / ( Factorial(e) * Factorial(t - e) ));*/
            /*
                        return p;*/

        }




    }
}
