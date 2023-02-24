// File:    LajkService.cs
// Created: 02 May 2020 22:33:37
// Purpose: Definition of Class LajkService

using System;
using Model;
using Model.Enum;
using System.Collections.Generic;
using bolnica.Service;

namespace Service
{
   public class LajkService : IService<Lajk, long>,
        ILajkService
   {
      
      
      public Repository.LajkRepository lajkRepository;

        public void Izmeni(Lajk entitet)
        {
            throw new NotImplementedException();
        }

        public Lajk Kreiraj(Lajk entitet)
        {
            throw new NotImplementedException();
        }

        public Lajk NadjiPoId(long id)
        {
            throw new NotImplementedException();
        }

        public List<Lajk> NadjiPoSlicici(VrstaSlicice slicica)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lajk> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public void Obrisi(Lajk entitet)
        {
            throw new NotImplementedException();
        }
    }
}