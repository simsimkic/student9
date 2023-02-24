using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class LekCSVConverter : ICSVConverter<Lek>
    {
        private readonly string _delimiter;
        private readonly string _dateTimeFormat;

        public LekCSVConverter(string delimiter, string dateTimeFormat)
        {
            _delimiter = delimiter;
            _dateTimeFormat = dateTimeFormat;
        }


        public Lek KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            List<Lekar> odabraniLekariZaOdobravanjeLeka = new List<Lekar>();
            List<Lekar> lekariKojiSuOdobriliLek = new List<Lekar>();
            List<Lekar> lekariKojiSuOdbiliLek = new List<Lekar>();
            List<Lek> zamene = new List<Lek>();

            tokeni[6].Split('.').ToList().ForEach(x => odabraniLekariZaOdobravanjeLeka.Add(new Lekar(int.Parse(x))));
            tokeni[7].Split('.').ToList().ForEach(x => lekariKojiSuOdobriliLek.Add(new Lekar(int.Parse(x))));
            tokeni[8].Split('.').ToList().ForEach(x => lekariKojiSuOdbiliLek.Add(new Lekar(int.Parse(x))));
            tokeni[9].Split('.').ToList().ForEach(x => zamene.Add(new Lek(x)));

            return new Lek(tokeni[0],
                tokeni[1], tokeni[2],
                int.Parse(tokeni[3]),
                Boolean.Parse(tokeni[4]),
                int.Parse(tokeni[5]),
                odabraniLekariZaOdobravanjeLeka,
                lekariKojiSuOdobriliLek,
                lekariKojiSuOdbiliLek, zamene
                );

        }

        public string KonvertujEntitetUSCVFormat(Lek lek)
            => string.Join(lek.Sifra, lek.Naziv,
                lek.Uputstvo, lek.Kolicina.ToString(),
                lek.Odobren.ToString(), lek.OdobriloLekara,
                String.Concat(lek.OdabraniLekariZaOdobravanjeLeka.Select(x => x.ToString())),
                String.Concat(lek.LekariKojiSuOdobriliLek.Select(x => x.ToString())),
                String.Concat(lek.LekariKojiSuOdbiliLek.Select(x => x.ToString())),
                String.Concat(lek.Zamene.Select(x => x.ToString()))
                );




    }
}
