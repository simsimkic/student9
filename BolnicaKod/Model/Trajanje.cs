// File:    Trajanje.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Trajanje

using System;

namespace Model
{
   public class Trajanje
   {
      private DateTime pocetak;
      private DateTime kraj;

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