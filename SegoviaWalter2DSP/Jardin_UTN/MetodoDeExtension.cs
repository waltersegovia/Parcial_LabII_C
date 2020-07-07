using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin_UTN
{
    static class MetodoDeExtension
    {
        public static int EvaluaRandom(this int n)
        {
            Random r = new Random();
            int i = r.Next(1, n);
            return i;
        }
    }
}
