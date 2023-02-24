// File:    OperacijaController.cs
// Created: 18 May 2020 18:07:26
// Purpose: Definition of Class OperacijaController

using System;
using System.Collections.Generic;
using Model;
using Model.Izvestaj;
using Model.Utill;
using bolnica.Controller.Abstract;
using bolnica.Service;

namespace Controller
{
   public class OperacijaController : IController<Operacija,int>, IOperacijaController
    {
        private readonly IService<Operacija, int> _service;
        private readonly IService<IzvestajOperacije, int> _serviceIzvestaj;     //PREIMENUJ
        private readonly IOperacijaService _serviceOperacije;
        private readonly IIzvestajOperacijeService _serviceIzvestaja;

        public OperacijaController(IService<Operacija,int> service, IOperacijaService serviceOperacije, IService<IzvestajOperacije, int> serviceIzvestaj, IIzvestajOperacijeService serviceIzvestaja)
        {
            _service = service;
            _serviceOperacije = serviceOperacije;
            _serviceIzvestaja = serviceIzvestaja;
            _serviceIzvestaj = serviceIzvestaj;
        }
      public Operacija Kreiraj(Operacija operacija)
      {
         return _service.Kreiraj(operacija);
      }
      
      public void Obrisi(Operacija operacija)
      {
         _service.Obrisi(operacija);
      }
      
      public void  Izmeni(Operacija operacija)
      {
         _service.Izmeni(operacija);
      }
      
      public IzvestajOperacije Kreiraj(IzvestajOperacije izvestajOperacije)
      {
         return _serviceIzvestaj.Kreiraj(izvestajOperacije);
      }
      
      public IEnumerable<Operacija> NadjiSve()
      {
         return _service.NadjiSve();
      }
      
      public Operacija NadjiPoId(int id)
      {
         return _service.NadjiPoId(id);
      }
      
      public List<Operacija> NadjiOperacijuPoLekaru(Lekar lekar)
      {
         return _serviceOperacije.NadjiPoLekaru(lekar);
      }
      
      
      public Model.Operacija NadjiOperacijuPoTerminuISali(Trajanje termin, int id)
      {
         return _serviceOperacije.NadjiOperacijuPoTerminuISali(termin,id);
      }
      
   
   }
}