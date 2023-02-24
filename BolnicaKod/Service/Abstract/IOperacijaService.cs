using System;
using System.Collections.Generic;
using Model;
using Model.Utill;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Service
{
    public interface IOperacijaService
    {

        List<Operacija> NadjiPoLekaru(Lekar lekar);

        Operacija NadjiOperacijuPoTerminuISali(Trajanje termin, int id);


    }
}
