using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Stream
{
    public interface ICSVStream<E>
    {

        void SacuvajSve(IEnumerable<E> entiteti);

        IEnumerable<E> CitajSve();

        void DodajNaKrajFajla(E entitet);
    }
}
