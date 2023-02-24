using bolnica.Model;
using bolnica.Model.Util;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class NotifikacijaCSVConverter : ICSVConverter<Notifikacija>
    {

        private readonly string _delimiter;
        private readonly string _dateTimeFormat;

        public NotifikacijaCSVConverter(string delimiter, string dateTimeFormat)
        {
            _delimiter = delimiter;
            _dateTimeFormat = dateTimeFormat;
        }

        public Notifikacija KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            return new Notifikacija(
                int.Parse(tokeni[0]),
                tokeni[1],
                new Autor(int.Parse(tokeni[2])),
                new Primalac(int.Parse(tokeni[3])),
                DateTime.Parse(tokeni[4])
                );
        }
       
        public string KonvertujEntitetUSCVFormat(Notifikacija notifikacija)
        => string.Join(
            notifikacija.Id.ToString(), 
            notifikacija.Tekst, 
            notifikacija.Autor.Id.ToString(),
            notifikacija.Primalac.Id.ToString(),
            notifikacija.Poslato.ToString(_dateTimeFormat)
            );


    }
}
