using System;
using System.Collections.Generic;

namespace bolnica.Repository.Abstract
{
    public interface IRepository<E, ID>
        where E : IIdentifiable<ID>
        where ID : IComparable
    {

        E NadjiPoId(ID id);

        IEnumerable<E> NadjiSve();

        E Kreiraj(E entitet);

        void Izmeni(E entitet);

        void Obrisi(E entitet);

        IEnumerable<E> Nadji(Func<E, bool> predikat);
    }
}
