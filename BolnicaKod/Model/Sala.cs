// File:    Sala.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Sala

using System;
using System.Collections.Generic;
using Model.Utill;
namespace Model
{
   public class Sala : Prostorija
   {
      private Operacija operacija;
      private System.Collections.Generic.List<Trajanje> trajanje;

        public Sala(int id) : base(id) 
        {

        }

        public Sala(int id, string naziv, PremestanjeInventara premestanjeInventara, List<Oprema> oprema, Renoviranje renoviranje, Operacija operacija, List<Trajanje> trajanje)
            : base(id, naziv, premestanjeInventara, oprema, renoviranje)
        {
            this.operacija = operacija;
            this.trajanje = trajanje;
        }

        public Operacija Operacija
        {
            get { return operacija; }
            set { operacija = value; }
        }
      
      /// <summary>
      /// Property for collection of Trajanje
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Trajanje> Trajanje
      {
         get
         {
            if (trajanje == null)
               trajanje = new System.Collections.Generic.List<Trajanje>();
            return trajanje;
         }
         set
         {
            RemoveAllTrajanje();
            if (value != null)
            {
               foreach (Trajanje oTrajanje in value)
                  AddTrajanje(oTrajanje);
            }
         }
      }
      
      /// <summary>
      /// Add a new Trajanje in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddTrajanje(Trajanje newTrajanje)
      {
         if (newTrajanje == null)
            return;
         if (this.trajanje == null)
            this.trajanje = new System.Collections.Generic.List<Trajanje>();
         if (!this.trajanje.Contains(newTrajanje))
            this.trajanje.Add(newTrajanje);
      }
      
      /// <summary>
      /// Remove an existing Trajanje from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveTrajanje(Trajanje oldTrajanje)
      {
         if (oldTrajanje == null)
            return;
         if (this.trajanje != null)
            if (this.trajanje.Contains(oldTrajanje))
               this.trajanje.Remove(oldTrajanje);
      }
      
      /// <summary>
      /// Remove all instances of Trajanje from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllTrajanje()
      {
         if (trajanje != null)
            trajanje.Clear();
      }
   
   }
}