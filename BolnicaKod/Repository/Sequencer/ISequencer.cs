using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.Sequencer
{
    public interface ISequencer<T>
    {
        void Inicijalizuj(T initId);

        T GenerisiId();

    }
}
