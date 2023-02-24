// File:    Komentar.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Komentar

using System;

namespace Model
{
   public class Komentar : Sadrzaj
   {
      private Pacijent pacijent;

        public Komentar(int id) : base (id)
        {

        }

        public Komentar(int id, string tekst, Korisnik autor, Pacijent pacijent, Lekar lekar)
            : base(id, tekst, autor)
        {
            this.pacijent = pacijent;
            this.lekar = lekar;
        }

       

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
                  oldPacijent.RemoveKomentar(this);
               }
               if (value != null)
               {
                  this.pacijent = value;
                  this.pacijent.AddKomentar(this);
               }
            }
         }
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
                  oldLekar.RemoveKomentar(this);
               }
               if (value != null)
               {
                  this.lekar = value;
                  this.lekar.AddKomentar(this);
               }
            }
         }
      }
   
   }
}