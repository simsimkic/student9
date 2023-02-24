using bolnica.Repository.CSV.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Stream
{
    class CSVStream<E> : ICSVStream<E> where E : class 
    {
        private readonly string _path;
        private readonly ICSVConverter<E> _converter;

        public CSVStream(string putanja, ICSVConverter<E> converter)
        {
            _path = putanja;
            _converter = converter;
        }

        public IEnumerable<E> CitajSve()
        {
            return File.ReadAllLines(_path)
                .Select(_converter.KonvertujCSVFormatUEntitet)
                .ToList();
        }

        public void DodajNaKrajFajla(E entitet)
        {
            File.AppendAllText(_path,
               _converter.KonvertujEntitetUSCVFormat(entitet) + Environment.NewLine); 
        }

        public void SacuvajSve(IEnumerable<E> entiteti)
        {
            WriteAllLinesToFile(
                entiteti
                .Select(_converter.KonvertujEntitetUSCVFormat)
                .ToList()
                );
        }

        public void WriteAllLinesToFile(IEnumerable<string> sadrzaj)
        {
            File.WriteAllLines(_path, sadrzaj.ToArray());
        }
    }
}
