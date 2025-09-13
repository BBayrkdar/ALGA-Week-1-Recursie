using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ALGA
{
    
    public class Collatz
    {
        public static int collatz_recursive(int n)
        {
            if (n <= 0) return -1;
            if (n == 1) return 0;
            long next = (n % 2 == 0) ? (n / 2L) : (3L * n + 1);
            if (next > int.MaxValue) throw new OverflowException("Intermediate value exceeds int range.");
            return 1 + collatz_recursive((int)next);
        }

        public static int collatz_iterative(int n)
        {
            if (n <= 0) return -1;
            int steps = 0;
            long i = n;
            while (i != 1)
            {
                i = i % 2 == 0 ? i / 2 : 3 * i + 1;
                steps++;
            }
            return steps;
        }
    }
}
