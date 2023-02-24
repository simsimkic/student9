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
    class UpravnikCSVConverter : ICSVConverter<Upravnik>
    {
        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public UpravnikCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }


        public Upravnik KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            Uloga uloga = (Uloga)Enum.Parse(typeof(Uloga), tokeni[3].ToString());
            List<Lek> lek = new List<Lek>();
            tokeni[8].Split('.').ToList().ForEach(x => lek.Add(new Lek(x)));
            return new Upravnik(int.Parse(tokeni[0]),
                tokeni[1],
                tokeni[2], uloga,
                new RadnoVreme(tokeni[4]),
                new Osoba(tokeni[5]),
                bool.Parse(tokeni[6]),
                new Prostorija(int.Parse(tokeni[7])),
                lek
                );
        }

        public string KonvertujEntitetUSCVFormat(Upravnik upravnik)
         => string.Join(_delimiter, upravnik.Id.ToString(),
             upravnik.KorisnickoIme,
             upravnik.Lozinka, upravnik.Uloga,
             upravnik.RadnoVreme,
             upravnik.Osoba,
             upravnik.Ulogovan.ToString(),
             upravnik.prostorija.Id.ToString(),
             String.Concat(upravnik.lek.Select(x => x.ToString()))
             );




    }
}
