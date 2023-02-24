// File:    LekRepository.cs
// Created: 03 May 2020 20:25:46
// Purpose: Definition of Class LekRepository

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
   public class LekRepository : CSVRepository<Lek, string>, IEagerCSVRepository<Lek, string>, ILekRepository
    {


      private const string IME_ENTITETA = "Lek";  
      public LekRepository(ICSVStream<Lek> stream, ISequencer<string> sequencer) : base(IME_ENTITETA, stream, sequencer) { }

      
      
      public Lek NadjiPoSifri(String sifra)
      {
         throw new NotImplementedException();
      }
      
      public List<Lek> NadjiSveLekove()
      {
         throw new NotImplementedException();
      }
      
      public Lek NadjiPoId(int id)
      {
         throw new NotImplementedException();
      }
      
      public Lek NadjiPoNazivu(String naziv)
      {
         throw new NotImplementedException();
      }
      
      public List<Lek> NadjiPoOdobrenim(Boolean odobren)
      {
         throw new NotImplementedException();
      }
     
     
      
      public Model.Lek SacuvajOdabraneLekare(Model.Lek lek, Model.Lekar lekar1, Model.Lekar lekar2)
      {
         throw new NotImplementedException();
      }

        public Lek VratiEager(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lek> VratiSveEager()
        {
            throw new NotImplementedException();
        }

        public LekService lekService;
   
   }
}