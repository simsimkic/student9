// File:    Korisnik.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Korisnik

using System;
using bolnica.Repository.Abstract;
using Model.Enum;
using Model.Utill;
namespace Model
{
   public class Korisnik : IIdentifiable<string>
   {
      int id;
      private String korisnickoIme;
      private String lozinka;
      private Uloga uloga;
      
      private RadnoVreme radnoVreme;
      private Osoba osoba;

        private bool ulogovan;


        public Korisnik(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }

        public Korisnik(int id, string korisnickoIme, string lozinka, Uloga uloga, RadnoVreme radnoVreme, Osoba osoba, bool ulogovan)
        {
            this.id = id;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.Uloga = uloga;
            this.radnoVreme = radnoVreme;
            this.osoba = osoba;
            this.ulogovan = ulogovan;
        }

        public Korisnik(int id, string korisnickoIme, string lozinka, Uloga uloga, Osoba osoba, bool ulogovan)

        {
            this.id = id;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.Uloga = uloga;
            this.osoba = osoba;
            this.ulogovan = ulogovan;
        }

        public string GetId() => KorisnickoIme;
        public void SetId(string korime) => KorisnickoIme = korime;

        public void PostaviKorIme(string korIme) => KorisnickoIme = korIme;
        public String KorisnickoIme
        {
            get { return korisnickoIme; }
            set { korisnickoIme = value; }
        }
        public String Lozinka
        {
            get { return lozinka; }
            set { lozinka = value; }
        }

        public Uloga Uloga
        {
            get { return uloga; }
            set { uloga = value; }
        }

        public RadnoVreme RadnoVreme
        {
            get { return radnoVreme; }
            set { radnoVreme = value; }
        }
       

      public Osoba Osoba
        {
            get { return osoba; }
            set { osoba = value; }
        }
        public bool Ulogovan
        {
            get { return ulogovan; }
            set { ulogovan = value; }
        }
       
    }
}