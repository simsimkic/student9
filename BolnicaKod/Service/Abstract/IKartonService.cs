using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace bolnica.Service
{
    public interface IKartonService
    {
        Karton NadjiPoKorisniku(Korisnik korisnik);

    }
}
