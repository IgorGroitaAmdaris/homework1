using System;

namespace messageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("It would be nice to compute some factorials!");
            Console.WriteLine("9! = " + factorial(9));

            int factorial(int n)
            {
                if (n == 0)
                {
                    return 1;
                }
                return n * factorial(n - 1);
            }
        
        }
        
    }
}
