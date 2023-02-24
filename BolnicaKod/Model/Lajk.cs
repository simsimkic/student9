// File:    Lajk.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Lajk

using System;
using bolnica.Model.Util;
using Model.Enum;
namespace Model
{
   public class Lajk
   {
      private VrstaSlicice slicica;
      
      private Pacijent pacijent;
      private Clanak clanak;
        private int id;

        public Lajk(int id) {
            this.id = id;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Lajk(VrstaSlicice slicica, Pacijent pacijent, Clanak clanak)
        {
            this.slicica = slicica;
            this.pacijent = pacijent;
            this.clanak = clanak;
        }

       

        public Pacijent Pacijent
        {
            get { return pacijent; }
            set { pacijent = value; }
        }

        public VrstaSlicice Slicica
        {
            get { return slicica; }
            set { slicica = value; }
        }
      /// <summary>
      /// Property for Clanak
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Clanak Clanak
      {
         get
         {
            return clanak;
         }
         set
         {
            if (this.clanak == null || !this.clanak.Equals(value))
            {
               if (this.clanak != null)
               {
                  Clanak oldClanak = this.clanak;
                  this.clanak = null;
                  oldClanak.RemoveLajk(this);
               }
               if (value != null)
               {
                  this.clanak = value;
                  this.clanak.AddLajk(this);
               }
            }
         }
      }
   
   }
}