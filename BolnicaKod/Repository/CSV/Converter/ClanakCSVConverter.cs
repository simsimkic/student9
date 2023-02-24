using bolnica.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    public class ClanakCSVConverter : ICSVConverter<Clanak>
    {
        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public ClanakCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public Clanak KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            List<Lajk> lajk = new List<Lajk>();
            List<Komentar> komentar = new List<Komentar>();
            tokeni[4].Split('.').ToList().ForEach(x => lajk.Add(new Lajk(int.Parse(x))));
            tokeni[6].Split('.').ToList().ForEach(x => komentar.Add(new Komentar(int.Parse(x))));
            return new Clanak(
                int.Parse(tokeni[0]), tokeni[1],
                new Autor(int.Parse(tokeni[2])),
                DateTime.Parse(tokeni[3]),
                lajk,
                new Lekar(int.Parse(tokeni[5])),
                komentar
                );
        }

            public string KonvertujEntitetUSCVFormat(Clanak clanak)
            => string.Join(_delimiter,
                clanak.Id.ToString(),
                clanak.Tekst,
                clanak.Autor.KorisnickoIme,
                clanak.Datum.ToString(_datetimeFormat),
                String.Concat(clanak.Lajk.Select(x => x.ToString())),
                clanak.lekar.KorisnickoIme,
                String.Concat(clanak.Komentar.Select(x => x.ToString()))
                ); 

    }
}
