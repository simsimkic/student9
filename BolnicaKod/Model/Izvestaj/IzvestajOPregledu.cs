// File:    IzvestajOPregledu.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class IzvestajOPregledu

using Model.Utill;
using System;
using System.Collections.Generic;

namespace Model
{
   public class IzvestajOPregledu
   {
      private int id;
      private String anamneza;
      private String dijagnoza;
      private String terapija;
      
      private Trajanje trajanjeTerapije;
      
      private Pregled pregled;
      private System.Collections.Generic.List<Lek> lek;   

        public IzvestajOPregledu(int id) {
            this.id = pregled.Id;
        }

        public IzvestajOPregledu(int id, string anamneza, string dijagnoza, string terapija, DateTime pocetak, DateTime kraj, Pregled pregled, List<Lek> lek)
        {
            this.id = id;
            this.anamneza = anamneza;
            this.dijagnoza = dijagnoza;
            this.terapija = terapija;
            this.trajanjeTerapije.Pocetak = pocetak;
            this.trajanjeTerapije.Kraj = kraj;
            this.pregled = pregled;
            this.lek = lek;
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public String Anamneza
        {
            get { return anamneza; }
            set { anamneza = value; }
        }

        public String Dijagnoza
        {
            get { return dijagnoza; }
            set { dijagnoza = value; }
        }

        public String Terapija
        {
            get { return terapija; }
            set { terapija = value; }
        }
        public Trajanje TrajanjeTerapije
        {
            get { return trajanjeTerapije; }
            set { trajanjeTerapije = value; }
        }

        public Pregled Pregled
        {
            get { return pregled; }
            set { pregled = value; }
            
        }
        /// <summary>
        /// Property for collection of Lek
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Lek> Lek
      {
         get
         {
            if (lek == null)
               lek = new System.Collections.Generic.List<Lek>();
            return lek;
         }
         set
         {
            RemoveAllLek();
            if (value != null)
            {
               foreach (Lek oLek in value)
                  AddLek(oLek);
            }
         }
      }
      
      /// <summary>
      /// Add a new Lek in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddLek(Lek newLek)
      {
         if (newLek == null)
            return;
         if (this.lek == null)
            this.lek = new System.Collections.Generic.List<Lek>();
         if (!this.lek.Contains(newLek))
            this.lek.Add(newLek);
      }
      
      /// <summary>
      /// Remove an existing Lek from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveLek(Lek oldLek)
      {
         if (oldLek == null)
            return;
         if (this.lek != null)
            if (this.lek.Contains(oldLek))
               this.lek.Remove(oldLek);
      }
      
      /// <summary>
      /// Remove all instances of Lek from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllLek()
      {
         if (lek != null)
            lek.Clear();
      }
   
   }
}