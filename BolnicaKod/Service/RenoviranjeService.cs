// File:    RenoviranjeService.cs
// Created: 18 May 2020 20:08:24
// Purpose: Definition of Class RenoviranjeService

using bolnica.Service;
using System;
using System.Collections.Generic;
using Model;

namespace Service
{
   public class RenoviranjeService : IService<Renoviranje, long>,
        IRenoviranjeService
   {
      
      
      public Repository.RenoviranjeRepository renoviranjeRepository;

        public void Izmeni(Renoviranje entitet)
        {
            throw new NotImplementedException();
        }

        public Renoviranje Kreiraj(Renoviranje entitet)
        {
            throw new NotImplementedException();
        }

        public Renoviranje NadjiPoId(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Renoviranje> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public void Obrisi(Renoviranje entitet)
        {
            throw new NotImplementedException();
        }
    }
}