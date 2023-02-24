// File:    Grad.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Grad

using System;

namespace Model.Utill
{
   public class Grad
   {
      private String naziv;
      private int postanskiBroj;
      
      private Drzava drzava;

      public Grad(string naziv, int postanskiBroj, Drzava drzava) 
      {
            this.Drzava = drzava;
            this.PostanskiBroj = postanskiBroj;
            this.naziv = naziv;
      }
   
        public String Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        
        public int PostanskiBroj
        {
            get { return postanskiBroj; }
            set { postanskiBroj = value; }
        }

        public Drzava Drzava
        {
            get { return drzava; }
            set { drzava = value; }
        }
   }
}