using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public interface IСoder
    {
        string Encode(string code);
        string Decode(string code);
    }
}
