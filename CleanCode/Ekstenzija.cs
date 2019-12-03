using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    static class Ekstenzija
    {
        public static string IntInFormat(this int value, string format) => $"{value}{format}";
    }
}
