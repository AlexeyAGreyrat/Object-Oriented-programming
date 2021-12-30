using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Palindromes
    {
        static public string Palindrom(string s)
        {
            string str = null;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                str = str + s[i];
            }
            return str;
        }
    }
}
