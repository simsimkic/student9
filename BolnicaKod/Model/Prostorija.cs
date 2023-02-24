// File:    Prostorija.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Prostorija

using bolnica.Repository.Abstract;
using System;
using System.Collections.Generic;

namespace Model
{
    public class Prostorija : IIdentifiable<int>
    {
        private int id;
        private string naziv;

        private PremestanjeInventara premestanjeInventara;
        private List<Oprema> oprema;
        private Renoviranje renoviranje;

        public Prostorija(int id)
        {
            this.id = id;
        }

        public Prostorija(int id, string naziv,List<Oprema> oprema)
        {
            this.id = id;
            this.naziv = naziv;
            this.oprema = oprema;
        }

        public Prostorija(int id, string naziv, PremestanjeInventara premestanje,
            List<Oprema> oprema, Renoviranje renoviranje)
        {
            this.id = id;
            this.naziv = naziv;
            this.oprema = oprema;
            this.renoviranje = renoviranje;
            this.premestanjeInventara = premestanje;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public List<Oprema> Oprema
        {
            get { return oprema; }
            set { oprema = value; }
        }

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