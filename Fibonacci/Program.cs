using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            ///0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
            ///
            var result = Fibonacci(Convert.ToInt32(9));
            Console.WriteLine($"Fibonacci : {result}");
        }
        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            if( n == 1)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
