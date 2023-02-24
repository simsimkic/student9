// File:    LekController.cs
// Created: 18 May 2020 18:07:27
// Purpose: Definition of Class LekController

using System;
using Model;
using bolnica.Service;
using bolnica.Controller.Abstract;
using System.Collections.Generic;

namespace Controller
{
   public class LekController : IController<Lek,string>, ILekController
   {
        private readonly IService<Lek, string> _service;
        private readonly ILekService _serviceLek;
      public LekController(IService<Lek, string> service, ILekService serviceLek)
        {
            _service = service;
            _serviceLek = serviceLek;
        }
      public Lek Kreiraj(Lek lek)
      {
         return _service.Kreiraj(lek);
      }
      
      public void Obrisi(Lek lek)
      {
         _service.Obrisi(lek);
      }
      
      public void Izmeni(Lek lek)
      {
         _service.Izmeni(lek);
      }
      
      public Lek SacuvajOdabraneLekare(Lek lek, Lekar lekar1, Lekar lekar2)
      {
         return _serviceLek.SacuvajOdabraneLekare(lek, lekar1, lekar2);
      }

        public IEnumerable<Lek> NadjiSve()
        {
            return _service.NadjiSve();
        }

        public Lek NadjiPoId(string id)
        {
            return _service.NadjiPoId(id);
        }
        
   
   }
}