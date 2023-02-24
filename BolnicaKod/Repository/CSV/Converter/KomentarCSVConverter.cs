using bolnica.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class KomentarCSVConverter : ICSVConverter<Komentar>
    {

        private readonly string _delimiter;

        public KomentarCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public Komentar KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            return new Komentar(
                int.Parse(tokeni[0]),
                tokeni[1], new Autor(int.Parse(tokeni[2])),
                new Pacijent(int.Parse(tokeni[3])),
                new Lekar(int.Parse(tokeni[4]))
                );

        }

       
        public string KonvertujEntitetUSCVFormat(Komentar komentar)
          => string.Join(_delimiter,
              komentar.Id.ToString(),
              komentar.Tekst,
              komentar.Autor.Id.ToString(),
              komentar.Pacijent.Id.ToString(), 
              komentar.Lekar.Id.ToString()
              
              );

    }
}
