// File:    Blog.cs
// Created: 18 May 2020 17:56:03
// Purpose: Definition of Class Blog

using System;
using System.Collections.Generic;

namespace Model
{
   public class Blog
   {
      private String naziv;
      
      private List<Clanak> clanak;

        public Blog(string naziv, List<Clanak> clanak)
            
        {
            this.naziv = naziv;
            this.clanak = clanak;
        }


        public String Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
       
        public List<Clanak> Clanak
        {
            get { return clanak; }
            set { clanak = value; }
        }
   }
}