using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class ProstorijaCSVConverter : ICSVConverter<Prostorija>
    {
        private readonly string _delimiter;
        private readonly string _dateTimeFormat;

        public ProstorijaCSVConverter(string delimiter, string dateTimeFormat)
        {
            _delimiter = delimiter;
            _dateTimeFormat = dateTimeFormat;
        }

        public Prostorija KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            List<Oprema> oprema = new List<Oprema>();
            tokeni[2].Split('.').ToList().ForEach(x => oprema.Add(new Oprema(x)));
            return new Prostorija(int.Parse(tokeni[0]), tokeni[1], oprema);

        }

        public string KonvertujEntitetUSCVFormat(Prostorija prostorija)
        => string.Join(_delimiter, prostorija.Id.ToString(),
            prostorija.Naziv,
            String.Concat(prostorija.Oprema.Select(x => x.ToString())));
    }
}
