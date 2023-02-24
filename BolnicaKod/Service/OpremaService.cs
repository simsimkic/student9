// File:    OpremaService.cs
// Created: 02 May 2020 21:45:08
// Purpose: Definition of Class OpremaService

using System;
using System.Collections.Generic;
using bolnica.Service;
using Model;

namespace Service
{
   public class OpremaService : IService<Oprema, string>,
        IOpremaService
   {
     
      
      public Repository.OpremaRepository opremaRepository;
      public ProstorijaService prostorijaService;
      public PremestanjeInventaraService premestanjeInventaraService;

        public bool DaLiJeNaStanju(int kolicina)
        {
            throw new NotImplementedException();
        }

        public void Izmeni(Oprema entitet)
        {
            throw new NotImplementedException();
        }

        public Oprema Kreiraj(Oprema entitet)
        {
            throw new NotImplementedException();
        }

        public Oprema NadjiPoId(string id)
        {
            throw new NotImplementedException();
        }

        public Oprema NadjiPoNazivu(string naziv)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Oprema> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public List<Oprema> NadjiSvePoSlicnomNazivu(string naziv)
        {
            throw new NotImplementedException();
        }


        public Oprema Naruci(Oprema oprema)
        {
            throw new NotImplementedException();
        }

        public void Obrisi(Oprema entitet)
        {
            throw new NotImplementedException();
        }
    }
}