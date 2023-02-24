using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;

namespace bolnica.Service
{
    public interface IKorisnikService
    {

        Korisnik Logovanje(String korisnickoIme, String lozinka);

        void Odjava(string korisnickoIme);

        bool KorisnickoImeValidno(String korisnickoIme);

        bool LozinkaValidna(String lozinka);

        bool DaLiJeSpecijalista(Korisnik korisnik);

        List<Korisnik> NadjiLekare();

        bool DaLiJeUlogovan(Korisnik korisnik);
    }
}
