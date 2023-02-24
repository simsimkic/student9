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
    class LekarCSVConverter : ICSVConverter<Lekar>
    {

        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public LekarCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public Lekar KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            Uloga uloga = (Uloga)Enum.Parse(typeof(Uloga), tokeni[3].ToString());
            List<Lek> lek = new List<Lek>();
            List<Pregled> pregled = new List<Pregled>();
            tokeni[8].Split('.').ToList().ForEach(x => lek.Add(new Lek(x)));
            tokeni[9].Split('.').ToList().ForEach(x => pregled.Add(new Pregled(int.Parse(x))));
            return new Lekar(int.Parse(tokeni[0]), tokeni[1], tokeni[2],
                 uloga, new RadnoVreme(tokeni[4]),
                 new Osoba(tokeni[5]),
                 bool.Parse(tokeni[6]),
                 bool.Parse(tokeni[7]),
                 lek, pregled

                );     

        }

        // public Lekar(int id, string korisnickoIme, string lozinka, Uloga uloga, RadnoVreme radnoVreme, 
        //Osoba osoba, Boolean ulogovan, Boolean specijalista, List<Lek> lek, Pregled[] pregled)
        public string KonvertujEntitetUSCVFormat(Lekar lekar)
         => string.Join(_delimiter, 
             lekar.Id.ToString(),
             lekar.KorisnickoIme, lekar.Lozinka,
             lekar.Uloga,
             lekar.RadnoVreme,
             lekar.Osoba,
             lekar.Ulogovan.ToString(),
             lekar.Specijalista.ToString(),
             String.Concat(lekar.Lek.Select(x => x.ToString())),
             String.Concat(lekar.Lek.Select(x => x.ToString()))
             );

    }
}
