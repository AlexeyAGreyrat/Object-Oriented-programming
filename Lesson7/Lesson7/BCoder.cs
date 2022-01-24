using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class BCoder : IСoder
    {
        char[] ru = { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };

        public string Decode(string code)
        {
            string str = null;

            foreach (var c in code)
            {
                for (var i = 0; i < ru.Length; i++)
                {
                    if (ru[i] == c)
                    {
                        str = str + ru[ru.Length-1-i];
                        break;
                    }
                }
            }
            return str;
        }

        public string Encode(string code)
        {
            string str = null;

            foreach (var c in code)
            {
                for(var i=0; i<ru.Length; i++)
                {
                    if (ru[i] == c)
                    {
                        str = str + ru[ru.Length-1-i];
                        break;
                    }
                }
            }
            return str;
        }
    }
}
