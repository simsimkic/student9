// File:    OperacijaRepository.cs
// Created: 03 May 2020 20:25:00
// Purpose: Definition of Class OperacijaRepository

using System;
using System.Collections.Generic;
using bolnica.Repository.Abstract;
using bolnica.Repository.CSV;
using bolnica.Repository.CSV.Stream;
using bolnica.Repository.Sequencer;
using Model;
using Model.Utill;
using Service;

namespace Repository
{
   public class OperacijaRepository : CSVRepository<Operacija, int>, IOperacijaRepository,IEagerCSVRepository<Operacija, int>
   {
        private const String IME_ENTITETA = "Operacije";

        public OperacijaService operacijaService;

        public OperacijaRepository(ICSVStream<Operacija> stream, ISequencer<int> sequencer)
            : base (IME_ENTITETA, stream, sequencer)
        {

        }

        public Operacija VratiEager(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Operacija> VratiSveEager()
        {
            throw new NotImplementedException();
        }
    }
}