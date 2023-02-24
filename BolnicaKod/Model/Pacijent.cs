// File:    Pacijent.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Pacijent

using System;
using System.Collections.Generic;
using Model.Enum;
using Model.Utill;

namespace Model
{
   public class Pacijent : Korisnik
   {
      
      private Boolean guest;
      private Boolean hospitalizovan = false;
      private Karton karton;

      private Soba soba;
      private System.Collections.Generic.List<Operacija> operacija;

        public Pacijent(int id) : base(id) { }

        public Pacijent(int id, string korisnickoIme, string lozinka, Uloga uloga, RadnoVreme radnoVreme, Osoba osoba, bool ulogovan, bool guest, bool hospitalizovan, Soba soba, List<Operacija> operacija, Karton karton, List<Pregled> pregled, List<Komentar> komentar)
            : base(id, korisnickoIme, lozinka, uloga, radnoVreme, osoba, ulogovan)

        {
            this.guest = guest;
            this.hospitalizovan = hospitalizovan;
            this.soba = soba;
            this.operacija = operacija;
            this.karton = karton;
            this.pregled = pregled;
            this.komentar = komentar;

        }

        public Pacijent(int id, string korisnickoIme, string lozinka, Uloga uloga, Osoba osoba, bool ulogovan, bool guest, bool hospitalizovan, Soba soba, List<Operacija> operacija, Karton karton, List<Pregled> pregled, List<Komentar> komentar)
            : base(id, korisnickoIme, lozinka, uloga, osoba, ulogovan)

        {
            this.guest = guest;
            this.hospitalizovan = hospitalizovan;
            this.soba = soba;
            this.operacija = operacija;
            this.karton = karton;
            this.pregled = pregled;
            this.komentar = komentar;
        }


        public Karton Karton
        {
            get { return karton; }
            set { karton = value; }
        }

        public Boolean Guest
        {
            get { return guest; }
            set { guest = value; }
        }
        public Boolean Hospitalizovan
        {
            get { return hospitalizovan; }
            set { hospitalizovan = value; }
        }

        public Soba Soba
        {
            get { return soba; }
            set { soba = value; }
        }

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
      private System.Collections.Generic.List<Pregled> pregled;
      
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
            newPregled.Pacijent = this;
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
               oldPregled.Pacijent = null;
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
               oldPregled.Pacijent = null;
            tmpPregled.Clear();
         }
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
            newKomentar.Pacijent = this;
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
               oldKomentar.Pacijent = null;
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
               oldKomentar.Pacijent = null;
            tmpKomentar.Clear();
         }
      }
     

       
   
   }
}