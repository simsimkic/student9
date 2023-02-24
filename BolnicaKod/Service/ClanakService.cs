// File:    ClanakService.cs
// Created: 02 May 2020 21:45:09
// Purpose: Definition of Class ClanakService

using System;
using System.Collections.Generic;
using bolnica.Service;
using Model;

namespace Service
{
   public class ClanakService : IService<Clanak, int>,
        IClanakService
   {
      
      
      public Repository.ClanakRepository clanakRepository;

        public void Izmeni(Clanak entitet)
        {
            throw new NotImplementedException();
        }

        public Clanak Kreiraj(Clanak entitet)
        {
            throw new NotImplementedException();
        }

        public Clanak NadjiPoId(int id)
        {
            throw new NotImplementedException();
        }

        public IClanakService NadjiPoLekaru(Lekar lekar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Clanak> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public void Obrisi(Clanak entitet)
        {
            throw new NotImplementedException();
        }
    }
}