// File:    Lekar.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Lekar

using Model.Enum;
using Model.Utill;
using System;
using System.Collections.Generic;

namespace Model
{
   public class Lekar : Korisnik
   {
      private Boolean specijalista;
      public List<Pregled> pregled;

        public Boolean Specijalista
        {
            get { return specijalista; }
            set { specijalista = value; }
        }
      
      private System.Collections.Generic.List<Lek> lek;

        public Lekar(int id) : base(id) { }

        public Lekar(int id, string korisnickoIme, string lozinka, Uloga uloga, RadnoVreme radnoVreme, Osoba osoba, Boolean ulogovan, Boolean specijalista, List<Lek> lek, List<Pregled> pregled)
            : base(id, korisnickoIme, lozinka, uloga, radnoVreme, osoba, ulogovan)
        {
            this.specijalista = specijalista;
            this.lek = lek;
            this.pregled = pregled;
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
      private System.Collections.Generic.List<Komentar> komentar;
      
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
         {
            this.komentar.Add(newKomentar);
            newKomentar.Lekar = this;
         }
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
            {
               this.komentar.Remove(oldKomentar);
               oldKomentar.Lekar = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Komentar from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllKomentar()
      {
         if (komentar != null)
         {
            System.Collections.ArrayList tmpKomentar = new System.Collections.ArrayList();
            foreach (Komentar oldKomentar in komentar)
               tmpKomentar.Add(oldKomentar);
            komentar.Clear();
            foreach (Komentar oldKomentar in tmpKomentar)
               oldKomentar.Lekar = null;
            tmpKomentar.Clear();
         }
      }
      private System.Collections.Generic.List<Clanak> clanak;
      
      /// <summary>
      /// Property for collection of Clanak
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Clanak> Clanak
      {
         get
         {
            if (clanak == null)
               clanak = new System.Collections.Generic.List<Clanak>();
            return clanak;
         }
         set
         {
            RemoveAllClanak();
            if (value != null)
            {
               foreach (Clanak oClanak in value)
                  AddClanak(oClanak);
            }
         }
      }
      
      /// <summary>
      /// Add a new Clanak in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddClanak(Clanak newClanak)
      {
         if (newClanak == null)
            return;
         if (this.clanak == null)
            this.clanak = new System.Collections.Generic.List<Clanak>();
         if (!this.clanak.Contains(newClanak))
         {
            this.clanak.Add(newClanak);
            newClanak.Lekar = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Clanak from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveClanak(Clanak oldClanak)
      {
         if (oldClanak == null)
            return;
         if (this.clanak != null)
            if (this.clanak.Contains(oldClanak))
            {
               this.clanak.Remove(oldClanak);
               oldClanak.Lekar = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Clanak from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllClanak()
      {
         if (clanak != null)
         {
            System.Collections.ArrayList tmpClanak = new System.Collections.ArrayList();
            foreach (Clanak oldClanak in clanak)
               tmpClanak.Add(oldClanak);
            clanak.Clear();
            foreach (Clanak oldClanak in tmpClanak)
               oldClanak.Lekar = null;
            tmpClanak.Clear();
         }
      }
      
      public System.Collections.Generic.List<Operacija> operacija;
      
      /// <summary>
      /// Property for collection of Operacija
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Operacija> Operacija
      {
         get
         {
            if (operacija == null)
               operacija = new System.Collections.Generic.List<Operacija>();
            return operacija;
         }
         set
         {
            RemoveAllOperacija();
            if (value != null)
            {
               foreach (Operacija oOperacija in value)
                  AddOperacija(oOperacija);
            }
         }
      }
      
      /// <summary>
      /// Add a new Operacija in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddOperacija(Operacija newOperacija)
      {
         if (newOperacija == null)
            return;
         if (this.operacija == null)
            this.operacija = new System.Collections.Generic.List<Operacija>();
         if (!this.operacija.Contains(newOperacija))
            this.operacija.Add(newOperacija);
      }
      
      /// <summary>
      /// Remove an existing Operacija from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveOperacija(Operacija oldOperacija)
      {
         if (oldOperacija == null)
            return;
         if (this.operacija != null)
            if (this.operacija.Contains(oldOperacija))
               this.operacija.Remove(oldOperacija);
      }
      
      /// <summary>
      /// Remove all instances of Operacija from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllOperacija()
      {
         if (operacija != null)
            operacija.Clear();
      }
      
   
   }
}