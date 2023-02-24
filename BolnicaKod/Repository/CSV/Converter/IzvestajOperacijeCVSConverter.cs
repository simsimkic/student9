using Model;
using Model.Izvestaj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    public class IzvestajOperacijeCSVConverter : ICSVConverter<IzvestajOperacije>

    {
        private readonly string _delimiter;

        public IzvestajOperacijeCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }



        public IzvestajOperacije KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            return new IzvestajOperacije(
                tokeni[0], new Operacija(int.Parse(tokeni[1]))
                );

        }

        public string KonvertujEntitetUSCVFormat(IzvestajOperacije izvestajOperacije)
          => string.Join(_delimiter,
              izvestajOperacije.Opis,
              izvestajOperacije.Operacija.Id.ToString()
              );
    }
}
