using ALGA;
using NUnit.Framework;
using System;

namespace ALGA_test
{
    [Category("String Reverse"), Timeout(1000)]
    public class StringReverseTest
    {
        [Test]
        public void StringReverseMethod()
        {
            Assert.AreEqual("", StringReverse.string_reverse(""));
            Assert.AreEqual("a", StringReverse.string_reverse("a"));
            Assert.AreEqual("AGLA", StringReverse.string_reverse("ALGA"));
            Assert.AreEqual("keimtiroglA", StringReverse.string_reverse("Algoritmiek"));
        }

        [Test]
        public void IsPalindrome()
        {
            Assert.AreEqual(true, StringReverse.is_palindrome(""));
            Assert.AreEqual(true, StringReverse.is_palindrome("a"));
            Assert.AreEqual(true, StringReverse.is_palindrome("abba"));
            Assert.AreEqual(false, StringReverse.is_palindrome("ALGA"));
            Assert.AreEqual(false, StringReverse.is_palindrome("Algoritmiek"));
            Assert.AreEqual(true, StringReverse.is_palindrome("parterretrap"));
            Assert.AreEqual(true, StringReverse.is_palindrome("gohangasalamiimalasagnahog"));
        }
        
        
        
        [Test]
        public void Reverse_Null_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => StringReverse.string_reverse(null));
        }

        [Test]
        public void Palindrome_Null_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => StringReverse.is_palindrome(null));
        }

    }
}
