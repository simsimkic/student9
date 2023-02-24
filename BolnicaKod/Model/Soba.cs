// File:    Soba.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Soba

using System;
using System.Collections.Generic;

namespace Model
{
   public class Soba : Prostorija
   {
      private int kreveti;
      
      private List<Pacijent> pacijent;

        public Soba(int id) : base(id)
        {

        }

        public Soba(int id, string naziv, PremestanjeInventara premestanjeInventara, List<Oprema> oprema, Renoviranje renoviranje, int kreveti, List<Pacijent> pacijent)
            : base(id, naziv, premestanjeInventara, oprema, renoviranje)

        {
            this.kreveti = kreveti;
            this.pacijent = pacijent;
        }

        public int Kreveti
        {
            get { return kreveti; }
            set { kreveti = value; }
        }

        public List<Pacijent> Pacijent
        {
            get { return pacijent; }
            set { pacijent = value; }
        }
   
   }
}