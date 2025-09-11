using ALGA;
using NUnit.Framework;
using System;

namespace ALGA_test
{
    [Category("Fibonacci"), Timeout(1000)]
    public class FibonacciTest
    {
        [Test]
        public void FibonacciRecursiveNegative()
        {
            Assert.AreEqual(0, Fibonacci.fibonacci_recursive(-5));
        }

        [Test]
        public void FibonacciRecursive()
        {
            Assert.AreEqual(0, Fibonacci.fibonacci_recursive(0));
            Assert.AreEqual(1, Fibonacci.fibonacci_recursive(1));
            Assert.AreEqual(1, Fibonacci.fibonacci_recursive(2));
            Assert.AreEqual(2, Fibonacci.fibonacci_recursive(3));
            Assert.AreEqual(3, Fibonacci.fibonacci_recursive(4));
            Assert.AreEqual(5, Fibonacci.fibonacci_recursive(5));
            Assert.AreEqual(8, Fibonacci.fibonacci_recursive(6));
            Assert.AreEqual(13, Fibonacci.fibonacci_recursive(7));
            Assert.AreEqual(21, Fibonacci.fibonacci_recursive(8));
            Assert.AreEqual(34, Fibonacci.fibonacci_recursive(9));
            Assert.AreEqual(55, Fibonacci.fibonacci_recursive(10));
        }

        [Test]
        public void FibonacciIterativeNegative()
        {
            Assert.AreEqual(0, Fibonacci.fibonacci_iterative(-5));
            Assert.AreEqual(0, Fibonacci.fibonacci_iterative(int.MinValue));
        }

        [Test]
        public void FibonacciIterative()
        {
            Assert.AreEqual(0, Fibonacci.fibonacci_iterative(0));
            Assert.AreEqual(1, Fibonacci.fibonacci_iterative(1));
            Assert.AreEqual(1, Fibonacci.fibonacci_iterative(2));
            Assert.AreEqual(2, Fibonacci.fibonacci_iterative(3));
            Assert.AreEqual(3, Fibonacci.fibonacci_iterative(4));
            Assert.AreEqual(5, Fibonacci.fibonacci_iterative(5));
            Assert.AreEqual(8, Fibonacci.fibonacci_iterative(6));
            Assert.AreEqual(13, Fibonacci.fibonacci_iterative(7));
            Assert.AreEqual(21, Fibonacci.fibonacci_iterative(8));
            Assert.AreEqual(34, Fibonacci.fibonacci_iterative(9));
            Assert.AreEqual(55, Fibonacci.fibonacci_iterative(10));
        }

        [Test]
        public void Consistency_Recursive_Equals_Iterative_ForSmallN()
        {
            for (int n = 0; n <= 25; n++)
            {
                Assert.AreEqual(
                    Fibonacci.fibonacci_iterative(n),
                    Fibonacci.fibonacci_recursive(n),
                    $"Mismatch at n={n}"
                );
            }
        }


        [Test]
        public void Iterative_LargestFittingValue()
        {
            Assert.AreEqual(1_836_311_903, Fibonacci.fibonacci_iterative(46));
        }

        [Test]
        public void Iterative_Overflow_At47()
        {
            Assert.Throws<OverflowException>(() => Fibonacci.fibonacci_iterative(47));
        }

        [Test]
        public void WhichIsFaster_IsIterative()
        {
            Assert.AreEqual(Fibonacci.Answer.IterativeIsFaster, Fibonacci.which_is_faster());
        }
    }
}
