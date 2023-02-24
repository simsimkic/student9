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
    class SekretarCSVConverter : ICSVConverter<Sekretar>
    {
        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public SekretarCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public Sekretar KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            Uloga uloga = (Uloga)Enum.Parse(typeof(Uloga), tokeni[3].ToString());
            List<Pregled> pregled = new List<Pregled>();
            tokeni[7].Split('.').ToList().ForEach(x => pregled.Add(new Pregled(int.Parse(x))));
            return new Sekretar(int.Parse(tokeni[0]),
                tokeni[1], tokeni[2],
                uloga, new RadnoVreme(tokeni[4]),
                 new Osoba(tokeni[5]),
                 bool.Parse(tokeni[6]),
                 pregled
                );

        }

        public string KonvertujEntitetUSCVFormat(Sekretar sekretar)
         => string.Join(_delimiter, sekretar.Id.ToString(),
             sekretar.KorisnickoIme, sekretar.Lozinka,
             sekretar.Uloga,
             sekretar.RadnoVreme,
             sekretar.Osoba,
             sekretar.Ulogovan.ToString(),
             String.Concat(sekretar.Pregled.Select(x => x.ToString()))
             );

    }
}
