// File:    RadnoVremeService.cs
// Created: 25 May 2020 13:58:25
// Purpose: Definition of Class RadnoVremeService

using System;
using System.Collections.Generic;
using bolnica.Service;
using Model.Utill;
namespace Service
{
   public class RadnoVremeService : IService<RadnoVreme, long>,
        IRadnoVremeService
   {
      
      public Repository.RadnoVremeRepository radnoVremeRepository;

        public void Izmeni(RadnoVreme entitet)
        {
            throw new NotImplementedException();
        }

        public RadnoVreme Kreiraj(RadnoVreme entitet)
        {
            throw new NotImplementedException();
        }

        public RadnoVreme NadjiPoId(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RadnoVreme> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public void Obrisi(RadnoVreme entitet)
        {
            throw new NotImplementedException();
        }
    }
}