using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Enum;
using System.Threading.Tasks;

namespace bolnica.Service
{
    public interface ILajkService
    {
        List<Lajk> NadjiPoSlicici(VrstaSlicice slicica);

    }
}
