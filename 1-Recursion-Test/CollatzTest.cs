using ALGA;
using NUnit.Framework;
using System;

namespace ALGA_test
{
    [Category("Collatz"), Timeout(1000)]
    public class CollatzTest
    {
        [Test]
        public void CollatzRecursiveNegative()
        {
            Assert.AreEqual(-1, Collatz.collatz_recursive(0));
            Assert.AreEqual(-1, Collatz.collatz_recursive(-1));
            Assert.AreEqual(-1, Collatz.collatz_recursive(-5));
        }

        [Test]
        public void CollatzRecursive()
        {
            Assert.AreEqual(0, Collatz.collatz_recursive(1));
            Assert.AreEqual(1, Collatz.collatz_recursive(2));
            Assert.AreEqual(2, Collatz.collatz_recursive(4));
            Assert.AreEqual(3, Collatz.collatz_recursive(8));
            Assert.AreEqual(4, Collatz.collatz_recursive(16));

            Assert.AreEqual(5, Collatz.collatz_recursive(5));
            Assert.AreEqual(5, Collatz.collatz_recursive(32));

            Assert.AreEqual(6, Collatz.collatz_recursive(10));
            Assert.AreEqual(6, Collatz.collatz_recursive(64));

            Assert.AreEqual(7, Collatz.collatz_recursive(3));
            Assert.AreEqual(7, Collatz.collatz_recursive(20));
            Assert.AreEqual(7, Collatz.collatz_recursive(21));
            Assert.AreEqual(7, Collatz.collatz_recursive(128));
        }

        [Test]
        public void CollatzIterativeNegative()
        {
            Assert.AreEqual(-1, Collatz.collatz_iterative(0));
            Assert.AreEqual(-1, Collatz.collatz_iterative(-1));
            Assert.AreEqual(-1, Collatz.collatz_iterative(-5));
        }

        [Test]
        public void CollatzIterative()
        {
            Assert.AreEqual(0, Collatz.collatz_iterative(1));
            Assert.AreEqual(1, Collatz.collatz_iterative(2));
            Assert.AreEqual(2, Collatz.collatz_iterative(4));
            Assert.AreEqual(3, Collatz.collatz_iterative(8));
            Assert.AreEqual(4, Collatz.collatz_iterative(16));

            Assert.AreEqual(5, Collatz.collatz_iterative(5));
            Assert.AreEqual(5, Collatz.collatz_iterative(32));

            Assert.AreEqual(6, Collatz.collatz_iterative(10));
            Assert.AreEqual(6, Collatz.collatz_iterative(64));

            Assert.AreEqual(7, Collatz.collatz_iterative(3));
            Assert.AreEqual(7, Collatz.collatz_iterative(20));
            Assert.AreEqual(7, Collatz.collatz_iterative(21));
            Assert.AreEqual(7, Collatz.collatz_iterative(128));
        }

        [Test]
        public void NegativeInputs_ReturnMinusOne()
        {
            Assert.AreEqual(-1, Collatz.collatz_iterative(int.MinValue));
            Assert.AreEqual(-1, Collatz.collatz_recursive(int.MinValue));
            Assert.AreEqual(-1, Collatz.collatz_iterative(-12345));
            Assert.AreEqual(-1, Collatz.collatz_recursive(-12345));
        }


        [Test]
        public void Implementations_Agree_On_SampleSet()
        {
            int[] samples = { 1, 2, 3, 5, 6, 7, 8, 9, 10, 12, 13, 19, 27, 97, 871, 6171 };
            foreach (var n in samples)
            {
                Assert.AreEqual(
                    Collatz.collatz_iterative(n),
                    Collatz.collatz_recursive(n),
                    $"Mismatch at n={n}"
                );
            }
        }

        [Test]
        public void Recursive_Throws_On_Intermediate_Int_Overflow()
        {
            // 3n+1 > int.MaxValue when n > (int.MaxValue - 1) / 3 = 715_827_882
            Assert.Throws<OverflowException>(() => Collatz.collatz_recursive(715_827_883));
        }
    }
}
