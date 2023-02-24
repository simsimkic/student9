// File:    KorisnikController.cs
// Created: 03 May 2020 18:28:29
// Purpose: Definition of Class KorisnikController

using System;
using Model;
using bolnica.Service;
using System.Collections.Generic;
using Model.Utill;
using bolnica.Controller.Abstract;

namespace Controller
{
   public class KorisnikController : IController<Korisnik,String>,IKorisnikController
   {
      private readonly IService<Korisnik, String> _service;
      private readonly IKorisnikService _serviceKorisnik;

      public KorisnikController(IService<Korisnik,String> service, IKorisnikService serviceKorisnik)
        {
            _service = service;
            _serviceKorisnik = serviceKorisnik;
        }
      
      public void Izmeni(Korisnik korisnik)
      {
         _service.Izmeni(korisnik);
      }
      
      public Korisnik Logovanje(String korisnickoIme, String lozinka)
      {
         return _serviceKorisnik.Logovanje(korisnickoIme,lozinka);
      }
      
      public Korisnik Kreiraj(Korisnik korisnik)
      {
         return _service.Kreiraj(korisnik);
      }
      
      public void Odjava(string korisnickoIme)
      {
         _serviceKorisnik.Odjava(korisnickoIme);
      }
      
      public List<Korisnik> NadjiLekare()
      {
         return _serviceKorisnik.NadjiLekare();
      }
      
      public Boolean DaLiJeSpecijalista(Lekar lekar)
      {
         return _serviceKorisnik.DaLiJeSpecijalista(lekar);
      }

      public IEnumerable<Korisnik> NadjiSve()
        {
            return _service.NadjiSve();
        }

      public Korisnik NadjiPoId(string id)
        {
            return _service.NadjiPoId(id);
        }

      public void Obrisi(Korisnik entitet)
        {
            _service.Obrisi(entitet);
        }
    }
}