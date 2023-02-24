// File:    LekService.cs
// Created: 02 May 2020 19:56:14
// Purpose: Definition of Class LekService

using System;
using System.Collections.Generic;
using bolnica.Service;
using Model;

namespace Service
{
   public class LekService : IService<Lek, string>,
        ILekService
   {
      
      public Repository.LekRepository lekRepository;

        public void Izmeni(Lek entitet)
        {
            throw new NotImplementedException();
        }

        public Lek Kreiraj(Lek entitet)
        {
            throw new NotImplementedException();
        }

        public Lek NadjiPoId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lek> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public void Obrisi(Lek entitet)
        {
            throw new NotImplementedException();
        }

        public Lek SacuvajOdabraneLekare(Lek lek, Lekar lekar1, Lekar lekar2)
        {
            throw new NotImplementedException();
        }

        public bool SifraValidna(string sifra)
        {
            throw new NotImplementedException();
        }
    }
}