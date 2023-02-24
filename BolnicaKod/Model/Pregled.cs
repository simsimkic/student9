// File:    Pregled.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Pregled

using bolnica.Repository.Abstract;
using System;

namespace Model
{
   public class Pregled : IIdentifiable<int>
   {
      private DateTime pocetak;
      private DateTime kraj;
      private int id;
      private Boolean obavljen = false;
      
      private Ordinacija ordinacija;

        public Pregled(int id) {
            this.id = id;
        }

        public Pregled(DateTime pocetak, DateTime kraj, int id, Boolean obavljen, Lekar lekar, Pacijent pacijent)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
            this.id = id;
            this.obavljen = obavljen;
            this.lekar = lekar;
            this.pacijent = pacijent;

        }

        public DateTime Pocetak
        {
            get { return pocetak; }
            set { pocetak = value; }
        }
        public DateTime Kraj
        {
            get { return kraj; }
            set { kraj = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Boolean Obavljen
        {
            get { return obavljen; }
            set { obavljen = value; }
        }


        /// <summary>
        /// Property for Ordinacija
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Ordinacija Ordinacija
      {
         get
         {
            return ordinacija;
         }
         set
         {
            if (this.ordinacija == null || !this.ordinacija.Equals(value))
            {
               if (this.ordinacija != null)
               {
                  Ordinacija oldOrdinacija = this.ordinacija;
                  this.ordinacija = null;
                  oldOrdinacija.RemovePregled(this);
               }
               if (value != null)
               {
                  this.ordinacija = value;
                  this.ordinacija.AddPregled(this);
               }
            }
         }
      }
      public Pacijent pacijent;
      
      /// <summary>
      /// Property for Pacijent
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Pacijent Pacijent
      {
         get
         {
            return pacijent;
         }
         set
         {
            if (this.pacijent == null || !this.pacijent.Equals(value))
            {
               if (this.pacijent != null)
               {
                  Pacijent oldPacijent = this.pacijent;
                  this.pacijent = null;
                  oldPacijent.RemovePregled(this);
               }
               if (value != null)
               {
                  this.pacijent = value;
                  this.pacijent.AddPregled(this);
               }
            }
         }
      }
      public Lekar lekar;

        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}