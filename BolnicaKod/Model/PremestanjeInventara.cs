// File:    PremestanjeInventara.cs
// Created: 18 May 2020 22:53:51
// Purpose: Definition of Class PremestanjeInventara

using System;
using System.Collections.Generic;

namespace Model
{
   public class PremestanjeInventara : Radovi
   {
      private System.Collections.Generic.List<Oprema> oprema;

        public PremestanjeInventara(DateTime pocetak, DateTime kraj, List<Oprema> oprema, Prostorija prostorija)
            :base (pocetak, kraj)
        {
            this.oprema = oprema;
            this.prostorija = prostorija;
        }

        /// <summary>
        /// Property for collection of Oprema
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Oprema> Oprema
      {
         get
         {
            if (oprema == null)
               oprema = new System.Collections.Generic.List<Oprema>();
            return oprema;
         }
         set
         {
            RemoveAllOprema();
            if (value != null)
            {
               foreach (Oprema oOprema in value)
                  AddOprema(oOprema);
            }
         }
      }
      
      /// <summary>
      /// Add a new Oprema in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddOprema(Oprema newOprema)
      {
         if (newOprema == null)
            return;
         if (this.oprema == null)
            this.oprema = new System.Collections.Generic.List<Oprema>();
         if (!this.oprema.Contains(newOprema))
            this.oprema.Add(newOprema);
      }
      
      /// <summary>
      /// Remove an existing Oprema from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveOprema(Oprema oldOprema)
      {
         if (oldOprema == null)
            return;
         if (this.oprema != null)
            if (this.oprema.Contains(oldOprema))
               this.oprema.Remove(oldOprema);
      }
      
      /// <summary>
      /// Remove all instances of Oprema from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllOprema()
      {
         if (oprema != null)
            oprema.Clear();
      }
      
      public Magacin magacin;
      public Prostorija prostorija;
   
   }
}