// File:    IzvestajOPregleduService.cs
// Created: 25 May 2020 14:16:10
// Purpose: Definition of Class IzvestajOPregleduService

using System;
using System.Collections.Generic;
using bolnica.Service;
using Model;

namespace Service
{
   public class IzvestajOPregleduService : IService<IzvestajOPregledu, long>,
        IIzvestajOPregleduService
   {
      public IzvestajOPregledu Kreiraj(IzvestajOPregledu izvestajOPregledu)
      {
         throw new NotImplementedException();
      }

        public IEnumerable<IzvestajOPregledu> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public IzvestajOPregledu NadjiPoId(long id)
        {
            throw new NotImplementedException();
        }

        public void Izmeni(IzvestajOPregledu entitet)
        {
            throw new NotImplementedException();
        }

        public void Obrisi(IzvestajOPregledu entitet)
        {
            throw new NotImplementedException();
        }

        public IzvestajOPregledu KreirajIzvestaj(IzvestajOPregledu izvestajOPregledu)
        {
            throw new NotImplementedException();
        }

        public Repository.IzvestajOPregleduRepository izvestajOPregleduRepository;
      public PregledService pregledService;
   
   }
}