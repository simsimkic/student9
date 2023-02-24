// File:    Lek.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Lek

using bolnica.Repository.Abstract;
using System;
using System.Collections.Generic;

namespace Model
{
   public class Lek : IIdentifiable<string>
   {
      private String sifra;
      private String naziv;
      private String uputstvo;
      private int kolicina = 0;
      private Boolean odobren = false;
         
      private int odobriloLekara = 0;
      private List<Lekar> odabraniLekariZaOdobravanjeLeka;
      private List<Lekar> lekariKojiSuOdobriliLek;
      private List<Lekar> lekariKojiSuOdbiliLek;
      
      private System.Collections.Generic.List<Lek> zamene;

        public Lek(String sifra)
        {
            this.sifra = sifra;
        }

        public Lek(string sifra, string naziv, string uputstvo, int kolicina, Boolean odobren, int odobriloLekara, List<Lekar> odabraniLekariZaOdobravanjeLeka, List<Lekar> lekariKojiSuOdobriliLek, List<Lekar> lekariKojiSuOdbiliLek, List<Lek> zamene)
        {
            this.sifra = sifra;
            this.naziv = naziv;
            this.uputstvo = uputstvo;
            this.kolicina = kolicina;
            this.odobren = odobren;
            this.odobriloLekara = odobriloLekara;
            this.odabraniLekariZaOdobravanjeLeka = odabraniLekariZaOdobravanjeLeka;
            this.lekariKojiSuOdobriliLek = lekariKojiSuOdobriliLek;
            this.lekariKojiSuOdbiliLek = lekariKojiSuOdbiliLek;
            this.zamene = zamene;
        }

        
        public String Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }

        public String Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public String Uputstvo
        {
            get { return uputstvo; }
            set { uputstvo = value; }
        }

        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }

        public Boolean Odobren
        {
            get { return odobren; }
            set { odobren = value; }
        }

        public int OdobriloLekara
        {
            get { return odobriloLekara; }
            set { odobriloLekara = value; }
        }

        public List<Lekar> OdabraniLekariZaOdobravanjeLeka
        {
            get { return odabraniLekariZaOdobravanjeLeka; }
            set { odabraniLekariZaOdobravanjeLeka = value; }
        }

        public List<Lekar> LekariKojiSuOdobriliLek
        {
            get { return lekariKojiSuOdobriliLek; }
            set { lekariKojiSuOdobriliLek = value; }
        }

        public List<Lekar> LekariKojiSuOdbiliLek
        {
            get { return lekariKojiSuOdbiliLek; }
            set { lekariKojiSuOdbiliLek = value; }
        }

        /// <summary>
        /// Property for collection of Lek
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Lek> Zamene
      {
         get
         {
            if (zamene == null)
               zamene = new System.Collections.Generic.List<Lek>();
            return zamene;
         }
         set
         {
            RemoveAllZamene();
            if (value != null)
            {
               foreach (Lek oLek in value)
                  AddZamene(oLek);
            }
         }
      }
      
      /// <summary>
      /// Add a new Lek in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddZamene(Lek newLek)
      {
         if (newLek == null)
            return;
         if (this.zamene == null)
            this.zamene = new System.Collections.Generic.List<Lek>();
         if (!this.zamene.Contains(newLek))
            this.zamene.Add(newLek);
      }
      
      /// <summary>
      /// Remove an existing Lek from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveZamene(Lek oldLek)
      {
         if (oldLek == null)
            return;
         if (this.zamene != null)
            if (this.zamene.Contains(oldLek))
               this.zamene.Remove(oldLek);
      }
      
      /// <summary>
      /// Remove all instances of Lek from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllZamene()
      {
         if (zamene != null)
            zamene.Clear();
      }

       

        string IIdentifiable<string>.GetId()
        {
            return Sifra;
        }

        public void SetId(string id)
        {
            Sifra = id;
        }
    }
}