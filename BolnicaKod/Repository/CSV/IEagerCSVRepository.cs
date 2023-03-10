using bolnica.Repository.Abstract;
using System;
using System.Collections.Generic;

namespace bolnica.Repository.CSV
{
    interface IEagerCSVRepository<E, ID>
        where E : IIdentifiable<ID>
        where ID : IComparable
    {

        E GetEager(ID id);

        IEnumerable<E> GetAllEager();

    }
}
