// File:    PremestanjeInventaraService.cs
// Created: 22 May 2020 10:21:04
// Purpose: Definition of Class PremestanjeInventaraService

using bolnica.Service;
using System;
using Model;
using System.Collections.Generic;

namespace Service
{
   public class PremestanjeInventaraService : IService<PremestanjeInventara, long>,
        IPremestanjeInventaraService
   {
      
      
      public Repository.PremestanjeInventaraRepository premestanjeInventaraRepository;
      public OpremaService opremaService;

        public void Izmeni(PremestanjeInventara entitet)
        {
            throw new NotImplementedException();
        }

        public PremestanjeInventara Kreiraj(PremestanjeInventara entitet)
        {
            throw new NotImplementedException();
        }

        public PremestanjeInventara NadjiPoId(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PremestanjeInventara> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public void Obrisi(PremestanjeInventara entitet)
        {
            throw new NotImplementedException();
        }
    }
}