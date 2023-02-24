using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Utill;

namespace bolnica.Service
{
    interface IProstorijaService
    {
        Prostorija NadjiPoNazivu(String naziv);

        Prostorija NadjiPoTerminuISali(Trajanje termin, int id);

        Prostorija NadjiPoTerminuIOrdinaciji(Trajanje termin, int id);
    }
}
