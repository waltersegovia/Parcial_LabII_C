using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DocentesException : Exception
    {
        public DocentesException(string mje) : base(mje)
        { }
        public DocentesException(string mje, Exception inner) : base(mje, inner)
        { }
    }
}
