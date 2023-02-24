// File:    NotifikacijaService.cs
// Created: 25 May 2020 13:31:47
// Purpose: Definition of Class NotifikacijaService

using bolnica.Service;
using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class NotifikacijaService : IService<Notifikacija, int>,
        INotifikacijaService
   {
      
      
      public Repository.NotifikacijaRepository notifikacijaRepository;

        public void Izmeni(Notifikacija entitet)
        {
            throw new NotImplementedException();
        }

        public Notifikacija Kreiraj(Notifikacija entitet)
        {
            return notifikacijaRepository.Kreiraj(entitet);
        }

        public Notifikacija NadjiPoId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Notifikacija> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public void Obrisi(Notifikacija entitet)
        {
            throw new NotImplementedException();
        }
    }
}