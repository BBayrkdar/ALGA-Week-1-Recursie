using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALGA
{
    public class PyramidProblem
    {
        public static int triangular_number_recursive(int n)
        {
            return n <= 0 ? 0 : n + triangular_number_recursive(n - 1);
        }

        public static int triangular_number_iterative(int n)
        {
            if (n <= 0) return 0;

            long sum = 0;
            for (int i = n; i >= 1; i--)
            {
                sum += i;
            }
            return checked((int)sum);
        }

        public static int triangular_number_function(int n)
        {
            if (n <= 0) return 0;
            long result = (long)n * (n + 1) / 2;
            return checked((int)result);
        }


        public static int triangular_number_recursive(char c) =>
           throw new ArgumentException("Char input not allowed. Please use an integer.");

        public static int triangular_number_iterative(char c) =>
            throw new ArgumentException("Char input not allowed. Please use an integer.");

        public static int triangular_number_function(char c) =>
            throw new ArgumentException("Char input not allowed. Please use an integer.");

    }
}
