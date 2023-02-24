using Model.Utill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class RadnoVremeCSVConverter : ICSVConverter<RadnoVreme>
    {
        private readonly string _delimiter;
        private readonly string _dateTimeFormat;

        public RadnoVremeCSVConverter(string delimiter, string dateTimeFormat)
        {
            _delimiter = delimiter;
            _dateTimeFormat = dateTimeFormat;
        }

        public RadnoVreme KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            return new RadnoVreme(DateTime.Parse(tokeni[0]), DateTime.Parse(tokeni[1]));
        }

        public string KonvertujEntitetUSCVFormat(RadnoVreme radnoVreme)
            => string.Join(_delimiter, radnoVreme.Pocetak.ToString(_dateTimeFormat),
                radnoVreme.Kraj.ToString(_dateTimeFormat));
    }
}
