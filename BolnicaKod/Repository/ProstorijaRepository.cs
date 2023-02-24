// File:    ProstorijaRepository.cs
// Created: 03 May 2020 20:24:26
// Purpose: Definition of Class ProstorijaRepository

using System;
using System.Collections.Generic;
using bolnica.Repository.Abstract;
using bolnica.Repository.CSV;
using bolnica.Repository.CSV.Stream;
using Model;
using Service;

namespace Repository
{
   public class ProstorijaRepository : CSVRepository<Prostorija,int>
    {
        public ProstorijaRepository(ICSVStream<Prostorija> stream) : base("pregled", stream)
        {
        }

       

        public IEnumerable<Prostorija> NadjiSveProstorije()
      {
            return NadjiSve();
      }
      
      
      
      public Prostorija NadjiPoNazivu(String naziv)
      {
         throw new NotImplementedException();
      }

        
   }
}