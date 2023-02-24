using bolnica.Model.Util;
using Model;
using Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class LajkCSVConverter : ICSVConverter<Lajk>
    {

        private readonly string _delimiter;
        
        public LajkCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
            
        }

        public Lajk KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            VrstaSlicice vrstaSlicice = (VrstaSlicice)Enum.Parse(typeof(VrstaSlicice), tokeni[0]);

            return new Lajk(
                vrstaSlicice, 
                new Pacijent(int.Parse(tokeni[1])),
                new Clanak(int.Parse(tokeni[2]))
                );

        }

        public string KonvertujEntitetUSCVFormat(Lajk lajk)
            => string.Join(_delimiter, 
                lajk.Slicica, 
                lajk.Pacijent.Id.ToString(), 
                lajk.Clanak.Id.ToString()
                );





    }
}
