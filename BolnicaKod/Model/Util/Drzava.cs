// File:    Drzava.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Drzava

using Model.Utill;
using System;

namespace Model
{
    public class Drzava
    {
        private String naziv;
        private String sifraDrzave;

        private Grad[] grad;

        public Drzava(string naziv, string sifraDrzave, Grad[] grad)
        {
            this.naziv = naziv;
            this.sifraDrzave = sifraDrzave;
            this.grad = grad;
        }

        public String Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public String SifraDrzave
        {
            get { return sifraDrzave; }
            set { sifraDrzave = value; }
        }

        public Grad[] Grad
        {
            get { return grad; }
            set { grad = value; }
        }
   }
}