// File:    Magacin.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Magacin

using System;
using System.Collections.Generic;

namespace Model
{
   public class Magacin
   {
      private List<Lek> lek;
      
      private System.Collections.Generic.List<Oprema> oprema;


        public Magacin(List<Lek> lek, List<Oprema> oprema, PremestanjeInventara premestanjeInventara)
        {
            this.lek = lek;
            this.oprema = oprema;
            this.premestanjeInventara = premestanjeInventara;
        }

        public List<Lek> Lek
        {
            get { return lek; }
            set { lek = value; }
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
      public PremestanjeInventara premestanjeInventara;
   
   }
}