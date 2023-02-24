// File:    KomentarService.cs
// Created: 02 May 2020 21:45:09
// Purpose: Definition of Class KomentarService

using bolnica.Service;
using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class KomentarService : IService<Komentar, int>
   {
        

        public Repository.KomentarRepository komentarRepository;

        public void Izmeni(Komentar entitet)
        {
            throw new NotImplementedException();
        }

        public Komentar Kreiraj(Komentar entitet)
        {
            throw new NotImplementedException();
        }

        public Komentar NadjiPoId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Komentar> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public void Obrisi(Komentar komentar)
        {
            komentarRepository.Obrisi(komentar);
        }
    }
}