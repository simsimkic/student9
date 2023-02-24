// File:    NotifikacijaRepository.cs
// Created: 25 May 2020 13:39:02
// Purpose: Definition of Class NotifikacijaRepository

using System;
using System.Collections.Generic;
using bolnica.Repository.Abstract;
using bolnica.Repository.CSV;
using bolnica.Repository.CSV.Stream;
using Model;
using Service;

namespace Repository
{
   public class NotifikacijaRepository : CSVRepository<Notifikacija, int>
   {
      public new Model.Notifikacija Kreiraj(Model.Notifikacija notifikacija)
      {
            return base.Kreiraj(notifikacija);
      }
        public NotifikacijaRepository(ICSVStream<Notifikacija> stream) : base("notifikacija", stream)
        {
        }


        public IEnumerable<Notifikacija> Nadji(Func<Notifikacija, bool> predikat)
        {
            throw new NotImplementedException();
        }

        public NotifikacijaService notifikacijaService;

    }
}