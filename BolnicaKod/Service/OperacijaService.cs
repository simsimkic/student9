// File:    OperacijaService.cs
// Created: 02 May 2020 21:45:08
// Purpose: Definition of Class OperacijaService

using System;
using Model;
using Model.Utill;
using System.Collections.Generic;
using bolnica.Service;

namespace Service
{
   public class OperacijaService : IOperacijaService,
        IService<Operacija, long>
    {

      public Repository.OperacijaRepository operacijaRepository;
      public IzvestajOperacijeService izvestajOperacijeService;
      public ProstorijaService prostorijaService;

        

        public void Izmeni(Operacija entitet)
        {
            throw new NotImplementedException();
        }

        public Operacija Kreiraj(Operacija entitet)
        {
            throw new NotImplementedException();
        }

        public Operacija NadjiOperacijuPoTerminuISali(Trajanje termin, int id)
        {
            throw new NotImplementedException();
        }

        public Operacija NadjiPoId(long id)
        {
            throw new NotImplementedException();
        }

        public List<Operacija> NadjiPoLekaru(Lekar lekar)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Operacija> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public void Obrisi(Operacija entitet)
        {
            throw new NotImplementedException();
        }
    }
}