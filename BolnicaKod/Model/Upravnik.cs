// File:    Upravnik.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Upravnik

using Model.Enum;
using Model.Utill;
using System;
using System.Collections.Generic;

namespace Model
{
   public class Upravnik : Korisnik
   {
        public Upravnik(int id, string korisnickoIme, string lozinka, Uloga uloga, RadnoVreme radnoVreme, Osoba osoba, Boolean ulogovan, Prostorija prostorija, List<Lek> lek)
            : base(id, korisnickoIme, lozinka, uloga, radnoVreme, osoba, ulogovan)
        {
            
            this.prostorija = prostorija;
            this.lek = lek;
        }

        public void IzvestajOZauzetostiProstorija(List<int> idProstorija, DateTime datumPocetka, DateTime datumKraja)
      {
         throw new NotImplementedException();
      }
      
      public void IzvestajOKoliciniLekova()
      {
         throw new NotImplementedException();
      }
      
      public Prostorija prostorija;
      public List<Lek> lek;

       

        public Prostorija Prostorija
        {
            get { return Prostorija; }
            set { Prostorija = value; }
        }

   
   }
}