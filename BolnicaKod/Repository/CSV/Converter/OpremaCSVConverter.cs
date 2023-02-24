using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class OpremaCSVConverter : ICSVConverter<Oprema>
    {
        private readonly string _delimiter;
        private readonly string _dateTimeFormat;    

        public OpremaCSVConverter(string delimiter, string dateTimeFormat)
        {
            _delimiter = delimiter;
            _dateTimeFormat = dateTimeFormat;
        }

        public Oprema KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            return new Oprema(tokeni[0], int.Parse(tokeni[1]), bool.Parse(tokeni[2]), new Prostorija(int.Parse(tokeni[3])));

        }

        public string KonvertujEntitetUSCVFormat(Oprema oprema)
            => string.Join(_delimiter, oprema.Naziv,
                oprema.Kolicina.ToString(),
                oprema.Fiksno.ToString(), oprema.Prostorija.Id);
    }
}
