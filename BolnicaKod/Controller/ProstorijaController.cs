// File:    ProstorijaController.cs
// Created: 18 May 2020 18:07:26
// Purpose: Definition of Class ProstorijaController

using System;
using Model;
using bolnica.Controller.Abstract;
using System.Collections.Generic;
using bolnica.Service;

namespace Controller
{
   public class ProstorijaController : IController<Prostorija,int>
   {
        private readonly IService<Prostorija, int> _service;
        public ProstorijaController(IService<Prostorija,int> service)
        {
            _service = service;
        }
      public Prostorija Kreiraj(Prostorija prostorija)
      {
         return _service.Kreiraj(prostorija);
      }
      
      public void Obrisi(Prostorija prostorija)
      {
         _service.Obrisi(prostorija);
      }
      
      public void Izmeni(Prostorija prostorija)
      {
         _service.Izmeni(prostorija);
      }

        public IEnumerable<Prostorija> NadjiSve()
        {
            return _service.NadjiSve();
        }

        public Prostorija NadjiPoId(int id)
        {
            return _service.NadjiPoId(id);
        }
        
   
   }
}