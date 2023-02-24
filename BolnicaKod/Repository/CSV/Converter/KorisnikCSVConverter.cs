using Model;
using Model.Enum;
using Model.Utill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class KorisnikCSVConverter : ICSVConverter<Korisnik>
    {
        private readonly string _delimiter;

        public KorisnikCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }


        public Korisnik KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            Uloga uloga = (Uloga)Enum.Parse(typeof(Uloga), tokeni[3]);
            return new Korisnik(int.Parse(tokeni[0]),
                tokeni[1], tokeni[2],
                uloga,
                new RadnoVreme(tokeni[4]),
                new Osoba(tokeni[5]),
                bool.Parse(tokeni[6])
                );

        }

        public string KonvertujEntitetUSCVFormat(Korisnik korisnik)
           => string.Join(_delimiter, korisnik.Id.ToString(),
               korisnik.KorisnickoIme,
               korisnik.Lozinka,
               korisnik.Uloga,
               korisnik.RadnoVreme,
               korisnik.Osoba,
               korisnik.Ulogovan
               );
    }
}

