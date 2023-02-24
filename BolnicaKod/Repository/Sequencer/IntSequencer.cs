using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.Sequencer
{
    class IntSequencer : ISequencer<int>
    {
        private int _sledeciId;

        public int GenerisiId()
        {
            return _sledeciId++;
        }

        public void Inicijalizuj(int initId)
        {
            _sledeciId = initId;
        }
    }
}
