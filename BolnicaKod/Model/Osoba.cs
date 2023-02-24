// File:    Osoba.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Osoba

using System;
using Model.Utill;
using Model.Enum;
namespace Model
{
   public class Osoba
   {
      private String ime;
      private String prezime;
      private String jmbg;
      private String adresa;
      private String telefon;
      private DateTime datumRodjenja;
      private String email;
      private Pol pol;
      
      private Grad grad;

        public Osoba() { }

        public Osoba(string ime, string prezime, string jmbg, string adresa, string telefon, DateTime datumRodjenja, string email, Pol pol, Grad grad)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.adresa = adresa;
            this.telefon = telefon;
            this.datumRodjenja = datumRodjenja;
            this.email = email;
            this.pol = pol;
            this.grad = grad;
        }

        public Osoba(string jmbg) {
            this.jmbg = jmbg;
        }

        public String Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public String Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public String Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        public String Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public String Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public Pol Pol
        {
            get { return pol; }
            set { pol = value; }
        }

        public Grad Grad
        {
            get { return grad; }
            set { grad = value; }
        }

    }
}