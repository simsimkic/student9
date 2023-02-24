// File:    Karton.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Karton

using System;
using System.Collections.Generic;
using Model.Izvestaj;
namespace Model
{
   public class Karton
   {
      private String hronicnaOboljenja;
      private String alergije;
        private int id;
        public List<IzvestajOPregledu> izvestajOPregledu;
        private Pacijent pacijent;

        public Karton(string hronicnaOboljenja, string alergije, Pacijent pacijent, List<IzvestajOPregledu> izvestajOPregledu, List<IzvestajOperacije> izvestajOperacije)
        {
            this.hronicnaOboljenja = hronicnaOboljenja;
            this.alergije = alergije;
            this.pacijent = pacijent;
            this.izvestajOPregledu = izvestajOPregledu;
            this.izvestajOperacije = izvestajOperacije;
        }

       public Karton(int id) {
            this.id = id;
        }

        public Karton(Pacijent pacijent) {
            this.pacijent = pacijent;
        }

        public String HronicnaOboljenja
        {
            get { return hronicnaOboljenja; }
            set { hronicnaOboljenja = value; }
        }

        public String Alergije
        {
            get { return alergije; }
            set { alergije = value; }
        }
      
        public Pacijent Pacijent
        {
            get { return pacijent; }
            set { pacijent = value; }
        }

       

        public System.Collections.Generic.List<IzvestajOperacije> izvestajOperacije;
      
      /// <summary>
      /// Property for collection of IzvestajOperacije
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<IzvestajOperacije> IzvestajOperacije
      {
         get
         {
            if (izvestajOperacije == null)
               izvestajOperacije = new System.Collections.Generic.List<IzvestajOperacije>();
            return izvestajOperacije;
         }
         set
         {
            RemoveAllIzvestajOperacije();
            if (value != null)
            {
               foreach (IzvestajOperacije oIzvestajOperacije in value)
                  AddIzvestajOperacije(oIzvestajOperacije);
            }
         }
      }
      
      /// <summary>
      /// Add a new IzvestajOperacije in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddIzvestajOperacije(IzvestajOperacije newIzvestajOperacije)
      {
         if (newIzvestajOperacije == null)
            return;
         if (this.izvestajOperacije == null)
            this.izvestajOperacije = new System.Collections.Generic.List<IzvestajOperacije>();
         if (!this.izvestajOperacije.Contains(newIzvestajOperacije))
            this.izvestajOperacije.Add(newIzvestajOperacije);
      }
      
      /// <summary>
      /// Remove an existing IzvestajOperacije from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveIzvestajOperacije(IzvestajOperacije oldIzvestajOperacije)
      {
         if (oldIzvestajOperacije == null)
            return;
         if (this.izvestajOperacije != null)
            if (this.izvestajOperacije.Contains(oldIzvestajOperacije))
               this.izvestajOperacije.Remove(oldIzvestajOperacije);
      }
      
      /// <summary>
      /// Remove all instances of IzvestajOperacije from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllIzvestajOperacije()
      {
         if (izvestajOperacije != null)
            izvestajOperacije.Clear();
      }
      
   
   }
}