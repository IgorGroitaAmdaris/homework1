using System;

namespace messageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("9! = " + factorial(9));

            int factorial(int n)
            {
                int p = 1;
                for(int i = 1; i<=n; ++i)
                {
                    p *= i;
                }
                return p;
            }
            double Gamma(double x)
            {
                /* Still awaits implementation*/
                return factorial((int)x);
            }
            Console.WriteLine(Gamma(4));

        }
        
    }
}
