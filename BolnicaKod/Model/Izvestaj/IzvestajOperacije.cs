// File:    IzvestajOperacije.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class IzvestajOperacije

using System;

namespace Model.Izvestaj
{
   public class IzvestajOperacije
   {
      private String opis;
        private int id;
      
      private Operacija operacija;

        public IzvestajOperacije(int id) 
        {
            this.id = Operacija.Id;
        }

        public IzvestajOperacije(string opis, Operacija operacija)
        {
            this.opis = opis;
            this.operacija = operacija;
        }

        public String Opis
        {
            get { return opis; }
            set { opis = value; }
        }
        public Operacija Operacija
        {
            get { return operacija; }
            set { operacija = value; }
        }

   }
    
   
}