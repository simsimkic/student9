using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Exception
{
    class VecPostojiException : System.Exception
    {
        public VecPostojiException(string poruka) : base(poruka)
        {

        }
    }
}
