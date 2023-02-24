// File:    KartonService.cs
// Created: 25 May 2020 14:18:15
// Purpose: Definition of Class KartonService

using System;
using System.Collections.Generic;
using bolnica.Service;
using Model;

namespace Service
{
   public class KartonService : IService<Karton, long>,
        IKartonService
   {
      

        public Repository.KartonRepository kartonRepository;
      public KorisnikService korisnikService;

        public void Izmeni(Karton entitet)
        {
            throw new NotImplementedException();
        }

        public Karton Kreiraj(Karton entitet)
        {
            throw new NotImplementedException();
        }

        public Karton NadjiPoId(long id)
        {
            throw new NotImplementedException();
        }

        public Karton NadjiPoKorisniku(Korisnik korisnik)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Karton> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public void Obrisi(Karton entitet)
        {
            throw new NotImplementedException();
        }
    }
}