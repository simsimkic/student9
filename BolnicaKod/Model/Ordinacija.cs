// File:    Ordinacija.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Ordinacija

using System;
using System.Collections.Generic;

namespace Model
{
   public class Ordinacija : Prostorija
   {
      private System.Collections.Generic.List<Pregled> pregled;

        public Ordinacija(int id, string naziv, PremestanjeInventara premestanjeInventara, List<Oprema> oprema, Renoviranje renoviranje, List<Pregled> pregled)
            : base(id, naziv, premestanjeInventara, oprema, renoviranje)
        {
            this.pregled = pregled;
        }

        /// <summary>
        /// Property for collection of Pregled
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Pregled> Pregled
      {
         get
         {
            if (pregled == null)
               pregled = new System.Collections.Generic.List<Pregled>();
            return pregled;
         }
         set
         {
            RemoveAllPregled();
            if (value != null)
            {
               foreach (Pregled oPregled in value)
                  AddPregled(oPregled);
            }
         }
      }
      
      /// <summary>
      /// Add a new Pregled in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddPregled(Pregled newPregled)
      {
         if (newPregled == null)
            return;
         if (this.pregled == null)
            this.pregled = new System.Collections.Generic.List<Pregled>();
         if (!this.pregled.Contains(newPregled))
         {
            this.pregled.Add(newPregled);
            newPregled.Ordinacija = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Pregled from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemovePregled(Pregled oldPregled)
      {
         if (oldPregled == null)
            return;
         if (this.pregled != null)
            if (this.pregled.Contains(oldPregled))
            {
               this.pregled.Remove(oldPregled);
               oldPregled.Ordinacija = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Pregled from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllPregled()
      {
         if (pregled != null)
         {
            System.Collections.ArrayList tmpPregled = new System.Collections.ArrayList();
            foreach (Pregled oldPregled in pregled)
               tmpPregled.Add(oldPregled);
            pregled.Clear();
            foreach (Pregled oldPregled in tmpPregled)
               oldPregled.Ordinacija = null;
            tmpPregled.Clear();
         }
      }
   
   }
}