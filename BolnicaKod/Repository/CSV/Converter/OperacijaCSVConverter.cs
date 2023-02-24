using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class OperacijaCSVConverter : ICSVConverter<Operacija>
    {
        private readonly string _delimiter;
        private readonly string _dateTimeFormat;

        public OperacijaCSVConverter(string delimiter, string dateTimeFormat)
        {
            _delimiter = delimiter;
            _dateTimeFormat = dateTimeFormat;
        }
      
        public Operacija KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            return new Operacija(DateTime.Parse(tokeni[0])
                , DateTime.Parse(tokeni[1])
                , int.Parse(tokeni[2]), bool.Parse(tokeni[3]), new Sala(int.Parse(tokeni[4])));
        }


        public string KonvertujEntitetUSCVFormat(Operacija operacija)
            => string.Join(_delimiter, operacija.Pocetak.ToString(_dateTimeFormat),
                operacija.Kraj.ToString(_dateTimeFormat),
                operacija.Id,
                operacija.Obavljen.ToString(),
                operacija.Sala.Id);

    }
}