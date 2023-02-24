using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    interface ICSVConverter<E> where E : class
    {

        string KonvertujEntitetUSCVFormat(E entitet);

        E KonvertujCSVFormatUEntitet(string CSVFormatEntiteta);

    }
}
