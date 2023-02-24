// File:    OpremaRepository.cs
// Created: 03 May 2020 20:31:05
// Purpose: Definition of Class OpremaRepository

using System;
using System.Collections.Generic;
using bolnica.Repository.Abstract;
using bolnica.Repository.CSV;
using bolnica.Repository.CSV.Stream;
using bolnica.Repository.Sequencer;
using Model;
using Service;

namespace Repository
{
   public class OpremaRepository : CSVRepository<Oprema, string>, IOpremaRepository, 
        IEagerCSVRepository<Oprema, string>
   {
        private const String IME_ENTITETA = "Oprema";
        

        
        public OpremaRepository(ICSVStream<Oprema> stream) : base (IME_ENTITETA, stream)
        {

        }

        

        public IEnumerable<Oprema> VratiSveEager()
        {
            throw new NotImplementedException();
        }

        public Oprema VratiEager(string id)
        {
            throw new NotImplementedException();
        }


    }
}