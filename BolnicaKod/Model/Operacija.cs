// File:    Operacija.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Operacija

using bolnica.Repository.Abstract;
using System;

namespace Model
{
    public class Operacija : IIdentifiable<int>
    {
        private DateTime pocetak;
        private DateTime kraj;
        private int id;
        private Boolean obavljen;

        private Sala sala;

        public Operacija()
        {

        }

        public Operacija(int id)
        {
            this.id = id;
        }

        public Operacija(DateTime pocetak, DateTime kraj, int id, Boolean obavljen, Sala sala)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
            this.id = id;
            this.obavljen = obavljen;
            this.sala = sala;
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

        public Sala Sala
        {
            get { return sala; }
            set { sala = value; }
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
    }
} 