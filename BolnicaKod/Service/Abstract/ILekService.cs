using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;

namespace bolnica.Service
{
    public interface ILekService
    {
        bool SifraValidna(String sifra);

        Lek SacuvajOdabraneLekare(Lek lek, Lekar lekar1, Lekar lekar2);

    }
}
