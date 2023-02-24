// File:    OcenjivanjeLekara.cs
// Created: 25 May 2020 15:40:08
// Purpose: Definition of Class OcenjivanjeLekara

using System;

namespace Model
{
   public class OcenjivanjeLekara
   {
      private int ocena;
      
      private Pacijent pacijent;
      private Lekar lekar;

        public OcenjivanjeLekara(int ocena, Pacijent pacijent, Lekar lekar)
        {
            this.ocena = ocena;
            this.pacijent = pacijent;
            this.lekar = lekar;
        }

        public int Ocena
        {
            get { return ocena; }
            set { ocena = value; }
        }

        public Pacijent Pacijent
        {
            get { return pacijent; }
            set { pacijent = value; }
        }

        public Lekar Lekar
        {
            get { return lekar; }
            set { lekar = value; }
        }
   
   }
}