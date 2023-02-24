// File:    Clanak.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Clanak

using System;
using System.Collections.Generic;

namespace Model
{
   public class Clanak : Sadrzaj
   {
      private DateTime datum;
      
      private System.Collections.Generic.List<Lajk> lajk;

        public Clanak(int id, string tekst, Korisnik autor, DateTime datum, List<Lajk> lajk, Lekar lekar, List<Komentar> komentar)
            : base(id, tekst, autor)
        {
            this.datum = datum;
            this.lajk = lajk;
            this.lekar = lekar;
            this.komentar = komentar;
        }

        public Clanak(int id) : base(id)
        {
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
      
      /// <summary>
      /// Property for collection of Lajk
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Lajk> Lajk
      {
         get
         {
            if (lajk == null)
               lajk = new System.Collections.Generic.List<Lajk>();
            return lajk;
         }
         set
         {
            RemoveAllLajk();
            if (value != null)
            {
               foreach (Lajk oLajk in value)
                  AddLajk(oLajk);
            }
         }
      }
      
      /// <summary>
      /// Add a new Lajk in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddLajk(Lajk newLajk)
      {
         if (newLajk == null)
            return;
         if (this.lajk == null)
            this.lajk = new System.Collections.Generic.List<Lajk>();
         if (!this.lajk.Contains(newLajk))
         {
            this.lajk.Add(newLajk);
            newLajk.Clanak = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Lajk from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveLajk(Lajk oldLajk)
      {
         if (oldLajk == null)
            return;
         if (this.lajk != null)
            if (this.lajk.Contains(oldLajk))
            {
               this.lajk.Remove(oldLajk);
               oldLajk.Clanak = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Lajk from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllLajk()
      {
         if (lajk != null)
         {
            System.Collections.ArrayList tmpLajk = new System.Collections.ArrayList();
            foreach (Lajk oldLajk in lajk)
               tmpLajk.Add(oldLajk);
            lajk.Clear();
            foreach (Lajk oldLajk in tmpLajk)
               oldLajk.Clanak = null;
            tmpLajk.Clear();
         }
      }
      public System.Collections.Generic.List<Komentar> komentar;
      
      /// <summary>
      /// Property for collection of Komentar
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Komentar> Komentar
      {
         get
         {
            if (komentar == null)
               komentar = new System.Collections.Generic.List<Komentar>();
            return komentar;
         }
         set
         {
            RemoveAllKomentar();
            if (value != null)
            {
               foreach (Komentar oKomentar in value)
                  AddKomentar(oKomentar);
            }
         }
      }
      
      /// <summary>
      /// Add a new Komentar in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddKomentar(Komentar newKomentar)
      {
         if (newKomentar == null)
            return;
         if (this.komentar == null)
            this.komentar = new System.Collections.Generic.List<Komentar>();
         if (!this.komentar.Contains(newKomentar))
            this.komentar.Add(newKomentar);
      }
      
      /// <summary>
      /// Remove an existing Komentar from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveKomentar(Komentar oldKomentar)
      {
         if (oldKomentar == null)
            return;
         if (this.komentar != null)
            if (this.komentar.Contains(oldKomentar))
               this.komentar.Remove(oldKomentar);
      }
      
      /// <summary>
      /// Remove all instances of Komentar from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllKomentar()
      {
         if (komentar != null)
            komentar.Clear();
      }
      public Lekar lekar;
      
      /// <summary>
      /// Property for Lekar
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Lekar Lekar
      {
         get
         {
            return lekar;
         }
         set
         {
            if (this.lekar == null || !this.lekar.Equals(value))
            {
               if (this.lekar != null)
               {
                  Lekar oldLekar = this.lekar;
                  this.lekar = null;
                  oldLekar.RemoveClanak(this);
               }
               if (value != null)
               {
                  this.lekar = value;
                  this.lekar.AddClanak(this);
               }
            }
         }
      }
   
   }
}