using System;

namespace messageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("It would be nice to compute some factorials!");

            Console.WriteLine("8! = " + factorial(8));
            int factorial(int n)
            {
                int p = 1;
                for(int i = 1; i<=n; ++i)
                {
                    p *= i;
                }
                return p;
            }

        }
    }
}
