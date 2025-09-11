using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class Fibonacci
    {
        public static int fibonacci_recursive(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return fibonacci_recursive(n - 1) + fibonacci_recursive(n - 2);
        }

        public static int fibonacci_iterative(int n)
        {
            Console.WriteLine($"Calculating fibonacci_iterative({n})");
            if (n <= 0) return 0;
            if (n == 1) return 1;

            int a = 0;
            int b = 1;

            for (int i = 2; i <= n; i++)
            {
                int next = checked(a + b);
                a = b;
                b = next;
            }
            return b;
        }

        public enum Answer { IterativeIsFaster, RecursiveIsFaster };

        public static Answer which_is_faster()
        {
            // recursief is exponentieel vanwege overlappende subproblemen.
            // iteratief is lineair. 
            return Answer.IterativeIsFaster;
        }
    }
}
