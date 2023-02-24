using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.Sequencer
{
    class LongSequencer : ISequencer<long>
    {

        private long _sledeciId;

        public long GenerisiId()
        {
            return _sledeciId++;
        }

        public void Inicijalizuj(long initId)
        {
            _sledeciId = initId;
        }

    }
}
