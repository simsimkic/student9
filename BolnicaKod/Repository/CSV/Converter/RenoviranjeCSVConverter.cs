using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class RenoviranjeCSVConverter : ICSVConverter<Renoviranje>
    {
        private readonly string _delimiter;
        private readonly string _dateTimeFormat;

        public RenoviranjeCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _dateTimeFormat = datetimeFormat;
        }

        public Renoviranje KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            return new Renoviranje(DateTime.Parse(tokeni[0]), DateTime.Parse(tokeni[1]),
                (TipRenoviranja)Enum.Parse(typeof(TipRenoviranja), tokeni[2]),
                new Prostorija(int.Parse(tokeni[3])));
        }

        public string KonvertujEntitetUSCVFormat(Renoviranje renoviranje)
            => string.Join(_delimiter, 
                renoviranje.Pocetak.ToString(_dateTimeFormat),
                renoviranje.Kraj.ToString(_dateTimeFormat),
                Enum.GetName(typeof(TipRenoviranja), renoviranje.TipRenoviranja),
                    renoviranje.Prostorija.Id);
    }
}
