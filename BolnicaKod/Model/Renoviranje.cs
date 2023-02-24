// File:    Renoviranje.cs
// Created: 18 May 2020 19:47:07
// Purpose: Definition of Class Renoviranje

using System;
using Model.Enum;
namespace Model
{
   public class Renoviranje : Radovi
   {
      private TipRenoviranja tipRenoviranja;
      
      private Prostorija prostorija;

        public Renoviranje(DateTime pocetak, DateTime kraj, TipRenoviranja tipRenoviranja, Prostorija prostorija)
            : base(pocetak, kraj)
        {
            this.tipRenoviranja = tipRenoviranja;
            this.prostorija = prostorija;
        }

        public Prostorija Prostorija
        {
            get { return prostorija; }
            set { prostorija = value; }
        }

        public TipRenoviranja TipRenoviranja
        {
            get { return tipRenoviranja; }
            set { tipRenoviranja = value; }
        }
   
   }
}