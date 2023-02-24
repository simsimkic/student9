// File:    RadnoVreme.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class RadnoVreme

using System;

namespace Model.Utill
{
    public class RadnoVreme
    {
        private DateTime pocetak;
        private DateTime kraj;

        public RadnoVreme(string v)
        {
        }

        public RadnoVreme(DateTime pocetak, DateTime kraj) 
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