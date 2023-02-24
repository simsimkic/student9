using Model;
using Model.Enum;
using Model.Utill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Model.Util
{
    class Primalac:Korisnik
    {
        public Primalac(int id) : base(id) { }

        public Primalac(int id, string korisnickoIme, string lozinka, Uloga uloga, RadnoVreme radnoVreme, Osoba osoba, bool ulogovan, Sadrzaj sadrzaj)
            : base(id, korisnickoIme, lozinka, uloga, radnoVreme, osoba, ulogovan)
        {

        }
    }
}
