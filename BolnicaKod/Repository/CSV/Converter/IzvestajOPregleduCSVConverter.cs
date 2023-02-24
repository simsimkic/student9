using Model;
using Model.Utill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class IzvestajOPregleduCSVConverter : ICSVConverter<IzvestajOPregledu>
    {
        private readonly string _delimiter;
        private readonly string _dateTimeFormat;



        public IzvestajOPregleduCSVConverter(string delimiter, string dateTimeFormat)
        {
            _delimiter = delimiter;
            _dateTimeFormat = dateTimeFormat;
            
        }

        public IzvestajOPregledu KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            List<Lek> lek = new List<Lek>();
            tokeni[7].Split('.').ToList().ForEach(x => lek.Add(new Lek(x)));
            return new IzvestajOPregledu(
                int.Parse(tokeni[0]),
                tokeni[1],
                tokeni[2], tokeni[3], 
                DateTime.Parse(tokeni[4]),
                DateTime.Parse(tokeni[5]),
                new Pregled(int.Parse(tokeni[6])),
                lek
                );
        }
        

        public string KonvertujEntitetUSCVFormat(IzvestajOPregledu izvestajOPregledu)
            => string.Join(_delimiter,
                izvestajOPregledu.Id.ToString(),
                izvestajOPregledu.Anamneza,
                izvestajOPregledu.Dijagnoza,
                izvestajOPregledu.Terapija,
                izvestajOPregledu.TrajanjeTerapije.Pocetak.ToString(_dateTimeFormat),
                izvestajOPregledu.TrajanjeTerapije.Kraj.ToString(_dateTimeFormat),
                izvestajOPregledu.Pregled.Id.ToString(),
                String.Concat(izvestajOPregledu.Lek.Select(x => x.ToString()))

                );
    } 

}
