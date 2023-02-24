using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Izvestaj;
using Model;
using Model.Utill;

namespace bolnica.Controller.Abstract
{
    public interface IOperacijaController
    {
        List<Operacija> NadjiOperacijuPoLekaru(Lekar lekar);
        Operacija NadjiOperacijuPoTerminuISali(Trajanje termin, int id);
    }
}
