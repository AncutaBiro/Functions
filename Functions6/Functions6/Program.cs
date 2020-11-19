using System;

namespace Functions6
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = 49;
            int e = 6;

/*
           
                for (int n = 4; n <= 6; ++n)
                {
                    Console.WriteLine((bc(6, n) * bc(49 - 6, 6 - n) / bc(49, 6)).ToString("0.00000000"));
                }*/
            
       
/*        Console.WriteLine(Probability(t, e));*/

            decimal tOut = Combinations(49, 6);
            decimal outcome = 1 / tOut;
            decimal prob = (outcome / tOut) * 100;

            Console.WriteLine(prob.ToString("0.00000000"));

/*            Console.WriteLine(Benomiolcoeficient(t, e));*/

        }

        static double bc(double n, double k)
        {
            if (k == 0 || k == n)
                return 1;
            return bc(n - 1, k - 1) + bc(n - 1, k);
        }



        static ulong Factorial(int n)

        {
            ulong product = 1;

            for (int i = 1; i <= n; i++)
            {
                product *= (ulong) i;
            }

            return product;
        }

        static decimal Combinations (int n, int k)
        {
            ulong divident = Factorial(n);
            Console.WriteLine(divident);

            ulong divisor = Factorial(k) - Factorial(n - k);
            Console.WriteLine(divisor);

            decimal d = (decimal)divident / divisor;

            Console.WriteLine (d);

            return d;
        }
   



        static decimal Probability(int t, int e) 
        {

            decimal p = 1;
            int i = 5;
            int j = 40;

            /*while (i > 0)
            {

                for (j = 40; j >= 40 - (i - 1); j--)
                {
                    p *= (decimal)i / j;
                    i--;
                }
            }

            Console.WriteLine(p.ToString("0.0000000000"));*/


            /*     for (int k = 1; k <= i; k++)
                 {
                     p *= (j + 1 - i) / i;
                 }

                 Console.WriteLine(p);

                 return p;*/


            Console.WriteLine(Factorial(i));
            Console.WriteLine(Factorial(j));
            Console.WriteLine(Factorial(j - i));


            p = 1/
               (Factorial(j) /
                Factorial(i) * Factorial(j - i));

            return p;

        }


        //bonomial coefficient
        







    /*static decimal Benomiolcoeficient(int t, int e)
    {
        decimal p = 1;

        for (int i = 1; i <= t; i++)
        {
            p*= (t + 1 - e) / e;
        }

        Console.WriteLine(p);

        return p; 

}*/
}

}