using Model;
using Model.Enum;
using Model.Utill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Model
{
    public class Autor : Korisnik
    {

        public Autor(int id) : base(id) { }

        public Autor (int id, string korisnickoIme, string lozinka, Uloga uloga, RadnoVreme radnoVreme, Osoba osoba, bool ulogovan, Sadrzaj sadrzaj)
            : base(id, korisnickoIme, lozinka, uloga, radnoVreme, osoba, ulogovan)
        { 
         
        }

        
    }
}
