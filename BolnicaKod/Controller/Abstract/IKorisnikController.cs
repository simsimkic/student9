using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace bolnica.Controller.Abstract
{
    public interface IKorisnikController
    {
        Korisnik Logovanje(String korisnickoIme, String lozinka);
        void Odjava(string korisnickoIme);
        List<Korisnik> NadjiLekare();
        Boolean DaLiJeSpecijalista(Lekar lekar);
    }
}
