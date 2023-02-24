// File:    IzvestajOperacijeService.cs
// Created: 25 May 2020 14:22:43
// Purpose: Definition of Class IzvestajOperacijeService

using System;
using System.Collections.Generic;
using bolnica.Service;
using Model;
using Model.Izvestaj;
using Model.Utill;

namespace Service
{
   public class IzvestajOperacijeService : IService<IzvestajOperacije, long>,
        IOperacijaService
   {
      public IzvestajOperacije Kreiraj(IzvestajOperacije izvestajOperacije)
      {
         throw new NotImplementedException();
      }

        public IEnumerable<IzvestajOperacije> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public IzvestajOperacije NadjiPoId(long id)
        {
            throw new NotImplementedException();
        }

        public void Izmeni(IzvestajOperacije entitet)
        {
            throw new NotImplementedException();
        }

        public void Obrisi(IzvestajOperacije entitet)
        {
            throw new NotImplementedException();
        }

        public List<Operacija> NadjiPoLekaru(Lekar lekar)
        {
            throw new NotImplementedException();
        }

        public Operacija NadjiOperacijuPoTerminuISali(Trajanje termin, int id)
        {
            throw new NotImplementedException();
        }

        public Repository.IzvestajOperacijeRepository izvestajOperacijeRepository;
      public OperacijaService operacijaService;
   
   }
}