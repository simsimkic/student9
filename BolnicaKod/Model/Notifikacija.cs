// File:    Notifikacija.cs
// Created: 25 May 2020 13:00:18
// Purpose: Definition of Class Notifikacija

using System;

namespace Model
{
   public class Notifikacija : Sadrzaj
   {
      public Korisnik Primalac { get; set; }
        public DateTime Poslato { get; set; }
        


        public Notifikacija(int id, string tekst, Korisnik autor,Korisnik primalac, DateTime poslato)
            : base(id, tekst, autor)
        {
            Primalac = primalac;
            Poslato = poslato;
        }

        
   }
}