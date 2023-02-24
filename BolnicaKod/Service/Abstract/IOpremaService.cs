using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Service
{
    public interface IOpremaService
    {
        List<Oprema> NadjiSvePoSlicnomNazivu(String naziv);

        bool DaLiJeNaStanju(int kolicina);

        Oprema NadjiPoNazivu(String naziv);

        Oprema Naruci(Oprema oprema);
    }
}
