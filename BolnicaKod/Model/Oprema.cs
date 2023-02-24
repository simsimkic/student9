// File:    Oprema.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Oprema

using bolnica.Repository.Abstract;
using System;

namespace Model
{
    public class Oprema : IIdentifiable<string>
    {
        private String naziv;
        private int kolicina;
        private Boolean fiksno;

        private Prostorija prostorija;

        public Oprema(string naziv)
        {
            this.naziv = naziv;
        }

        override
            public string ToString()
            {
                return this.naziv;
            }

        public string GetId()
        {
            return naziv;
        }

        public void SetId(string id)
        {
            naziv = id;
        }

        public Oprema(string naziv, int kolicina, Boolean fiksno, Prostorija prostorija)
        {
            this.naziv = naziv;
            this.kolicina = kolicina;
            this.fiksno = fiksno;
            this.prostorija = prostorija;
        }

        public String Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }
        public Boolean Fiksno
        {
            get { return fiksno; }
            set { fiksno = value; }
        }
        public Prostorija Prostorija
        {
            get { return prostorija; }
            set { prostorija = value; }
        }
             
    }
}
