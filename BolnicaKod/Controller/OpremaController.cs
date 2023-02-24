// File:    OpremaController.cs
// Created: 18 May 2020 18:07:26
// Purpose: Definition of Class OpremaController

using System;
using Model;
using System.Collections.Generic;
using bolnica.Controller.Abstract;
using bolnica.Service;

namespace Controller
{
   public class OpremaController : IController<Oprema,string>, IOpremaController
   {
        private readonly IService<Oprema, string> _service;
        private readonly IOpremaService _serviceOprema;
        public OpremaController(IService<Oprema,string> service, IOpremaService serviceOprema)
        {
            _service = service;
            _serviceOprema = serviceOprema;
        }
      public Oprema Kreiraj(Oprema oprema)
      {
         return _service.Kreiraj(oprema);
      }
      
      public void Obrisi(Oprema oprema)
      {
         _service.Obrisi(oprema);
      }
      
      public void Naruci(Oprema oprema)
      {
         _serviceOprema.Naruci(oprema);
      }
      
      public List<Oprema> NadjiFiksnuOpremu(String naziv)
      {
         return _serviceOprema.NadjiSvePoSlicnomNazivu(naziv);
      }

        public IEnumerable<Oprema> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public Oprema NadjiPoId(string id)
        {
            throw new NotImplementedException();
        }

        public void Izmeni(Oprema entitet)
        {
            throw new NotImplementedException();
        }
    }
}