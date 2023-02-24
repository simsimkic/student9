using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.Abstract
{
    public interface IId<T>
    {
        T GetId();
        void SetId(T id);
    }
}
