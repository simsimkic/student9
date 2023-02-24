// File:    Sekretar.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Sekretar

using Model.Enum;
using Model.Utill;
using System;
using System.Collections.Generic;

namespace Model
{
   public class Sekretar : Korisnik
   {
      private List<Pregled> pregled;

        public Sekretar(int id, string korisnickoIme, string lozinka, Uloga uloga, RadnoVreme radnoVreme, Osoba osoba, Boolean ulogovan, List<Pregled> pregled)
            : base(id, korisnickoIme, lozinka, uloga, radnoVreme, osoba, ulogovan)
        {
            this.pregled = pregled;
        }


        public List<Pregled> Pregled
        {
            get { return pregled; }
            set { pregled = value; }
        }
   }
}