using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Controller.Abstract
{
    public interface IController<E, ID> where E : class
    {
        IEnumerable<E> NadjiSve();
        E NadjiPoId(ID id);
        E Kreiraj(E entitet);
        void Izmeni(E entitet);
        void Obrisi(E entitet);
    }
}
