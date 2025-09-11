using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
    public class StringReverse
    {
        public static String string_reverse(String s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));
            if (s.Length <= 1) return s;
            return s[s.Length - 1] + string_reverse(s.Substring(0, s.Length - 1));
        }

        public static bool is_palindrome(String s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));

            if (s.Length <= 1) return true;
            if (s[0] != s[s.Length - 1]) return false;
            return is_palindrome(s.Substring(1, s.Length - 2));
        }
    }
}
