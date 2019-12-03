using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj05z1
{
    static class Extensions
    {
        public static string IntInFormat(this int value, string format) => $"{value}{format}";
    }
}
