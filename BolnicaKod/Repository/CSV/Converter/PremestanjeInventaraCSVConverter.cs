using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class PremestanjeInventaraCSVConverter : ICSVConverter<PremestanjeInventara>
    {
        private readonly string _delimiter;
        private readonly string _dateTimeFormat;

        public PremestanjeInventaraCSVConverter(string delimiter, string dateTimeFormat)
        {
            _delimiter = delimiter;
            _dateTimeFormat = dateTimeFormat;
        }
       
        public PremestanjeInventara KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            List<Oprema> oprema = new List<Oprema>();
            tokeni[2].Split('.').ToList().ForEach(x => oprema.Add(new Oprema(x)));
            return new PremestanjeInventara(DateTime.Parse(tokeni[0]), DateTime.Parse(tokeni[1]), oprema, new Prostorija(int.Parse(tokeni[3])));
        }
        public string KonvertujEntitetUSCVFormat(PremestanjeInventara premestanjeInventara)
            => string.Join(_delimiter, premestanjeInventara.Pocetak.ToString(_dateTimeFormat),
                premestanjeInventara.Kraj.ToString(_dateTimeFormat),
                String.Concat(premestanjeInventara.Oprema.Select(x => x.ToString())),
                premestanjeInventara.prostorija.Id);
    }
}
