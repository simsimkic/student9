// File:    Sadrzaj.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Sadrzaj

using bolnica.Repository.Abstract;
using System;

namespace Model
{
   public abstract class Sadrzaj : IIdentifiable<int>
   {
      private int id;
      private String tekst;
      
      private Korisnik autor;

        public Sadrzaj(int id)
        {
            this.id = id;
        }

        public Sadrzaj(int id, string tekst, Korisnik autor)
        {

            this.id = id;
            this.tekst = tekst;
            this.autor = autor;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Tekst
        {
            get { return tekst; }
            set { tekst = value; }
        }
        public Korisnik Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int GetId() => Id;

        public void SetId(int id) => Id = id;
    }
}