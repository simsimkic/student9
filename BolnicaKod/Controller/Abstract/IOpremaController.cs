using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace bolnica.Controller.Abstract
{
    public interface IOpremaController
    {
        void Naruci(Oprema oprema);
        List<Oprema> NadjiFiksnuOpremu(String naziv);
    }
}
