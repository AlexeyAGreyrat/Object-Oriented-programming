using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson3
{
    class Search
    {
        static public void SearchMail(ref string s)
        {
            var str = s.Split('&','\n');
            string pow = null;
            for (int i = 0; i < str.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(str[i]))
                {
                    break;
                }
                else
                {
                    str[i] = str[i].Trim();
                    var ser = Regex.IsMatch(str[i],
                           @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                           RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                    if(ser == true)
                    {
                        pow = pow + str[i] + "\n";
                    }
                }                
            }
            s = pow;
        }
    }
}
