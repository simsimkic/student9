using Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace bolnica.Repository.Abstract
{
    public interface IRegistrovaniKorisnikRepository : IRepository<Korisnik, string>

    {
        Korisnik NadjiPoKorisnickomImenuILozinki(String korIme, String lozinka);
    }
}
