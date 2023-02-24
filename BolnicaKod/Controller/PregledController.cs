// File:    PregledController.cs
// Created: 18 May 2020 18:07:27
// Purpose: Definition of Class PregledController

using System;
using System.Collections.Generic;
using Model;
using bolnica.Controller.Abstract;
using bolnica.Service;

namespace Controller
{
   public class PregledController : IController<Pregled,int> ,IPregledController
   {
        private readonly IService<Pregled, int> _service;
        private readonly IPregledService _servicePregled;
        private readonly IIzvestajOPregleduService _serviceIzvestaj;
        public PregledController(IService<Pregled,int> service, IPregledService servicePregled, IIzvestajOPregleduService serviceIzvestaj)
        {
            _service = service;
            _servicePregled = servicePregled;
            _serviceIzvestaj = serviceIzvestaj;
        }
      public Pregled Kreiraj(Pregled pregled)
      {
            return _service.Kreiraj(pregled);
      }
      
      public void Izmeni(Pregled pregled)
      {
         _service.Izmeni(pregled);
      }
      
      public void Obrisi(Pregled pregled)
      {
         _service.Obrisi(pregled);
      }
      
      public List<Pregled> NadjiPoDatumu(DateTime pocetak, DateTime kraj)
      {
         return _servicePregled.PronadjiPoDatumu(pocetak, kraj);
      }
      
      public List<Pregled> NadjiPoOrdinaciji(int brojOrdinacije)
      {
         return _servicePregled.PronadjiPoOrdinaciji(brojOrdinacije);
      }
      
      public List<Pregled> NadjiPoImenuIliPrezimenu(String imeIliPrezime)
      {
        return  _servicePregled.PronadjiPoImenuIliPrezimenu(imeIliPrezime);
      }
      
      public List<Pregled> NadjiSlobodanTerminPoLekaru(Lekar lekar)
      {
         return _servicePregled.NadjiSlobodanTerminPoLekaru(lekar);
      }
      
      public List<Pregled> NadjiSlobodanTerminPoVremenu(DateTime pocetak, DateTime kraj)
      {
            return _servicePregled.NadjiSlobodanTerminPoVremenu(pocetak, kraj);
      }
      
      public Boolean DaLiJePrioritetLekar()
      {
         return _servicePregled.DaLiJePrioritetLekar();
      }
      
      public List<Pregled> NadjiSlobodanTerminPoLekaruIVremenu(DateTime pocetak, Model.Lekar lekar, DateTime kraj)
      {
         return _servicePregled.NadjiSlobodanTerminPoLekaruIVremenu(pocetak, lekar, kraj);
      }
      
      public void OdbijZakazivanje(Pregled pregled)
      {
         _servicePregled.OdbijZakazivanje(pregled);
      }
      
      public DateTime IzaberiVremenskiPeriodTermina(DateTime pocetak, DateTime kraj)
      {
         return _servicePregled.IzaberiVremenskiPeriodTermina(pocetak,kraj);
      }
      
      public Lekar IzaberiLekara(List<Lekar> lekar)
      {
         return _servicePregled.IzaberiLekara(lekar);
      }
      
      public void IzaberiPrioritet(String lekar, String vremenskiInterval)
      {
         _servicePregled.IzaberiPrioritet(lekar, vremenskiInterval);
      }
      
      public IzvestajOPregledu KreirajIzvestaj(IzvestajOPregledu izvestajOPregledu)
      {
         return _serviceIzvestaj.KreirajIzvestaj(izvestajOPregledu);
      }

        public Pregled NadjiPoId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pregled> NadjiSve()
        {
            return _service.NadjiSve();
        }

    }
}