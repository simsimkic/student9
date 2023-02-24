using Model;
using Model.Izvestaj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter

{
    class KartonCSVConverter : ICSVConverter<Karton>
    {
        private readonly string _delimiter;

        public KartonCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
           
        }

        public Karton KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            List<IzvestajOperacije> izvestajOperacije = new List<IzvestajOperacije>();
            List<IzvestajOPregledu> izvestajOPregledu = new List<IzvestajOPregledu>();
            tokeni[3].Split('.').ToList().ForEach(x => izvestajOperacije.Add(new IzvestajOperacije(int.Parse(x))));
            tokeni[4].Split('.').ToList().ForEach(x => izvestajOPregledu.Add(new IzvestajOPregledu(int.Parse(x))));
            return new Karton(tokeni[0], tokeni[1], 
                new Pacijent(int.Parse(tokeni[2])), 
                izvestajOPregledu,
                izvestajOperacije
                );
        }

        public string KonvertujEntitetUSCVFormat(Karton karton)
            => string.Join(_delimiter,
                karton.HronicnaOboljenja, karton.Alergije, 
                karton.Pacijent.Id.ToString(),
                String.Concat(karton.izvestajOPregledu.Select(x => x.ToString())),
                String.Concat(karton.izvestajOperacije.Select(x => x.ToString()))
                );




    }
}
