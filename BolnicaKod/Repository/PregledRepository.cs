// File:    PregledRepository.cs
// Created: 03 May 2020 20:25:35
// Purpose: Definition of Class PregledRepository

using System;
using System.Collections.Generic;
using Model;
using Service;
using bolnica.Repository.CSV;
using bolnica.Repository.CSV.Stream;
using System.Linq;
using bolnica.Repository.Abstract;

namespace Repository
{
   public class PregledRepository : CSVRepository<Pregled, int>, IRepository<Pregled, int>
   {
        public PregledRepository(ICSVStream<Pregled> stream) : base("pregled", stream)
        {
        }
      
      public IEnumerable<Pregled> NadjiSve(int id)
      {
            return NadjiSve();
      }
      
      public Pregled NadjiPoDatumuIOrdinaciji(DateTime datumVreme, Ordinacija ordinacija)
      {
         throw new NotImplementedException();
      }
      
      public List<Pregled> NadjiPoLekaru(Lekar lekar)
      {
            var slobodniTermini = Nadji(termin => termin.Obavljen == false);
            return slobodniTermini.ToList();
      }
      
      public List<Pregled> NadjiObavljene(Boolean obavljen)
      {
         throw new NotImplementedException();
      }
      
      public List<Pregled> NadjiPoPacijentu(Model.Pacijent pacijent)
      {
         throw new NotImplementedException();
      }
      
      public List<Pregled> NadjiPoIntervalu(DateTime pocetak, DateTime kraj)
      {
         throw new NotImplementedException();
      }
   
   }
}