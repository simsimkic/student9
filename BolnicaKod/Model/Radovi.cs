// File:    Radovi.cs
// Created: 25 May 2020 13:53:19
// Purpose: Definition of Class Radovi

using System;

namespace Model
{
   public class Radovi
   {
      private DateTime pocetak;
      private DateTime kraj;

        public Radovi(DateTime pocetak, DateTime kraj)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
        }


        public DateTime Pocetak
        {
            get { return pocetak; }
            set { pocetak = value; }
        }

        public DateTime Kraj
        {
            get { return kraj; }
            set { kraj = value; }
        }
    }
}