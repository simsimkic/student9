// File:    PregledService.cs
// Created: 02 May 2020 20:14:14
// Purpose: Definition of Class PregledService

using System;
using Model;
using Model.Utill;
using System.Collections.Generic;
using bolnica.Service;
using bolnica.Repository.Abstract;

namespace Service
{
   public class PregledService : IService<Pregled, int>,
        IPregledService
   {
      
      public Repository.PregledRepository pregledRepository;
      public IzvestajOPregleduService izvestajOPregleduService;
      public ProstorijaService prostorijaService;

        public bool DaLiJePrioritetLekar()
        {
            throw new NotImplementedException();
        }

        public Lekar IzaberiLekara(List<Lekar> lekar)
        {
            throw new NotImplementedException();
        }

        public void IzaberiPrioritet(string lekar, string vremenskiInterval)
        {
            throw new NotImplementedException();
        }

        public DateTime IzaberiVremenskiPeriodTermina(DateTime pocetak, DateTime kraj)
        {
            throw new NotImplementedException();
        }

        public void Izmeni(Pregled entitet)
        {
            throw new NotImplementedException();
        }

        public Pregled Kreiraj(Pregled entitet)
        {
            return pregledRepository.Kreiraj(entitet);
        }

        public Pregled NadjiPoId(int id)
        {
            throw new NotImplementedException();
        }

        public Prostorija NadjiPoTerminuIOrdinaciji(Trajanje termin, int id)
        {
            throw new NotImplementedException();
        }

        public List<Pregled> NadjiSlobodanTerminPoLekaru(Lekar lekar)
        {
            return pregledRepository.NadjiPoLekaru(lekar);
        }

        public List<Pregled> NadjiSlobodanTerminPoLekaruIVremenu(DateTime pocetak, Lekar lekar, DateTime kraj)
        {
            throw new NotImplementedException();
        }

        public List<Pregled> NadjiSlobodanTerminPoVremenu(DateTime pocetak, DateTime kraj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pregled> NadjiSve()
        {
            return pregledRepository.NadjiSve();
        }

        public void Obrisi(Pregled entitet)
        {
            pregledRepository.Obrisi(entitet);
        }

        public void OdbijZakazivanje(Pregled pregled)
        {
            throw new NotImplementedException();
        }

        public void PomeriSvePregledeOd(Trajanje termin)
        {
            throw new NotImplementedException();
        }

        public List<Pregled> PrikaziBuduce()
        {
            throw new NotImplementedException();
        }

        public List<Pregled> PrikaziPreglede()
        {
            throw new NotImplementedException();
        }

        public List<Pregled> PronadjiPoDatumu(DateTime pocetak, DateTime kraj)
        {
            throw new NotImplementedException();
        }

        public List<Pregled> PronadjiPoImenuIliPrezimenu(string parametarpretrage)
        {
            throw new NotImplementedException();
        }

        public List<Pregled> PronadjiPoOrdinaciji(int brOrdinacije)
        {
            throw new NotImplementedException();
        }
    }
}