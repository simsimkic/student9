// File:    LajkController.cs
// Created: 25 May 2020 14:05:47
// Purpose: Definition of Class LajkController

using System;
using Model;
using System.Collections.Generic;
using bolnica.Controller.Abstract;
using bolnica.Service;

namespace Controller
{
   public class LajkController : IController<Lajk,int>
   {
        private readonly IService<Lajk, int> _service;
        public LajkController(IService<Lajk,int> service)
        {
            _service = service;
        }
      public Lajk Kreiraj(Lajk lajk)
      {
         return _service.Kreiraj(lajk);
      }
      
      public void Obrisi(Lajk lajk)
      {
         _service.Obrisi(lajk);
      }
      
      public void Izmeni(Lajk lajk)
      {
         _service.Izmeni(lajk);
      }

        public IEnumerable<Lajk> NadjiSve()
        {
            return _service.NadjiSve();
        }

        public Lajk NadjiPoId(int id)
        {
            return _service.NadjiPoId(id);
        }
        
   
   }
}