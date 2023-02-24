using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace bolnica.Controller.Abstract
{
    public interface ILekController
    {
        Lek SacuvajOdabraneLekare(Lek lek, Lekar lekar1, Lekar lekar2);
    }
}
