// File:    IzvestajOZauzetostiLekara.cs
// Created: 25 May 2020 16:15:48
// Purpose: Definition of Class IzvestajOZauzetostiLekara

using Model.Utill;
using System;

namespace Model
{
   public class IzvestajOZauzetostiLekara
   {
      private Lekar lekar;
      private Trajanje trajanje;

        public IzvestajOZauzetostiLekara(Lekar lekar, Trajanje trajanje)
        {
            this.lekar = lekar;
            this.trajanje = trajanje;
        }

        public Lekar Lekar
        {
            get { return lekar; }
            set { lekar = value; }
        }
        public Trajanje Trajanje
        {
            get { return trajanje; }
            set { trajanje = value; }
        }
   }
}