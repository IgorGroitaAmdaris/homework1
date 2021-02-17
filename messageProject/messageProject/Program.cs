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

            //Some other functions

            double squareRoot(double x)
            {
                if (x > 1)
                {
                    double left = 1, right = x;
                    while(right-left>0.002)
                    {
                        double mid = (left + right) / 2;
                        if (mid * mid > right)
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid;
                        }
                    }
                    return left;
                }
                else return -2.0;
            }

            Console.WriteLine("tsdhis" + squareRoot(56.0));
        }
        
    }
}
