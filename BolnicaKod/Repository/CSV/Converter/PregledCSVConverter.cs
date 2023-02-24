using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class PregledCSVConverter : ICSVConverter<Pregled>
    {
        private readonly string _delimiter;
        private readonly string _dateTimeFormat;

        public PregledCSVConverter(string delimiter, string dateTimeFormat)
        {
            _delimiter = delimiter;
            _dateTimeFormat = dateTimeFormat;
        }

        public Pregled KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            return new Pregled(DateTime.Parse(tokeni[0]), DateTime.Parse(tokeni[1]), int.Parse(tokeni[2]), bool.Parse(tokeni[3]), new Lekar(int.Parse(tokeni[4])), new Pacijent(int.Parse(tokeni[5])));

        }

        public string KonvertujEntitetUSCVFormat(Pregled pregled)
         => string.Join(_delimiter, pregled.Pocetak.ToString(_dateTimeFormat),
             pregled.Kraj.ToString(_dateTimeFormat),
             pregled.Id.ToString(),
             pregled.Obavljen.ToString(),
             pregled.lekar.Id.ToString(),
             pregled.pacijent.Id.ToString());
    }
}
