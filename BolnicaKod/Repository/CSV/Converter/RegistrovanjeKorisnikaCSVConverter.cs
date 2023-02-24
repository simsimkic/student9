using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class RegistrovanjeKorisnikaCSVConverter : ICSVConverter<Korisnik>
    {
        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public RegistrovanjeKorisnikaCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public Korisnik KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            return new Korisnik()
        }

        public string KonvertujEntitetUSCVFormat(Korisnik entitet)
        {
            throw new NotImplementedException();
        }
    }
}
