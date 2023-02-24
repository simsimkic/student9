using Model;
using Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class PacijentCSVConverter : ICSVConverter<Pacijent>
    {
        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public PacijentCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public Pacijent KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            Uloga uloga = (Uloga)Enum.Parse(typeof(Uloga), tokeni[3].ToString());
            List<Operacija> operacija = new List<Operacija>();
            List<Pregled> pregled = new List<Pregled>();
            List<Komentar> komentar = new List<Komentar>();
            tokeni[9].Split('.').ToList().ForEach(x => operacija.Add(new Operacija(int.Parse(x))));
            tokeni[11].Split('.').ToList().ForEach(x => pregled.Add(new Pregled(int.Parse(x))));
            tokeni[12].Split('.').ToList().ForEach(x => komentar.Add(new Komentar(int.Parse(x))));
            return new Pacijent(int.Parse(tokeni[0]),
                tokeni[1],
                tokeni[2], uloga,
                 new Osoba(tokeni[4]),
                 bool.Parse(tokeni[5]),
                 bool.Parse(tokeni[6]),
                 bool.Parse(tokeni[7]),
                 new Soba(int.Parse(tokeni[8])),
                 operacija,
                 new Karton(int.Parse(tokeni[10])),
                 pregled,
                 komentar
                );

        }
        
        public string KonvertujEntitetUSCVFormat(Pacijent pacijent)
         => string.Join(_delimiter, pacijent.Id,ToString(),
             pacijent.KorisnickoIme,
             pacijent.Lozinka, pacijent.Uloga,
             pacijent.Osoba,
             pacijent.Ulogovan.ToString(), pacijent.Guest.ToString(),
             pacijent.Hospitalizovan.ToString(), 
             pacijent.Soba.Id.ToString(),
             String.Concat(pacijent.Operacija.Select(x => x.ToString())),
             pacijent.Karton, 
             String.Concat(pacijent.Pregled.Select(x => x.ToString())),
             String.Concat(pacijent.Komentar.Select(x => x.ToString()))

             );
    }
}
