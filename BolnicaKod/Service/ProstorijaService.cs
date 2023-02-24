// File:    ProstorijaService.cs
// Created: 02 May 2020 21:45:08
// Purpose: Definition of Class ProstorijaService

using System;
using System.Collections.Generic;
using bolnica.Service;
using Model;
using Model.Utill;
namespace Service
{
   public class ProstorijaService : IService<Prostorija, long>,
        IProstorijaService
   {
      
      
      public Repository.ProstorijaRepository prostorijaRepository;
      public OperacijaService operacijaService;
      public PregledService pregledService;
      public OpremaService opremaService;
        

        public void Izmeni(Prostorija entitet)
        {
            prostorijaRepository.Izmeni(entitet);
        }

        public Prostorija Kreiraj(Prostorija entitet)
        {
            return prostorijaRepository.Kreiraj(entitet);
        }

        public Prostorija NadjiPoId(long id)
        {
            throw new NotImplementedException();
        }

        public Prostorija NadjiPoNazivu(string naziv)
        {
            throw new NotImplementedException();
        }

        public Prostorija NadjiPoTerminuIOrdinaciji(Trajanje termin, int id)
        {
            throw new NotImplementedException();
        }

        public Prostorija NadjiPoTerminuISali(Trajanje termin, int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prostorija> NadjiSve()
        {
            return prostorijaRepository.NadjiSve();
        }

        public void Obrisi(Prostorija entitet)
        {
            prostorijaRepository.Obrisi(entitet);
        }
    }
}