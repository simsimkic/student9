// File:    UlogovaniKorisnik.cs
// Created: 02 June 2020 12:48:12
// Purpose: Definition of Class UlogovaniKorisnik

using System;

namespace Model
{
   public class UlogovaniKorisnik
   {
      private UlogovaniKorisnik()
      {
         
      }
      
      private static UlogovaniKorisnik instance = null;
      private Korisnik korisnik;
      
      public UlogovaniKorisnik GetInstance()
      {
         if (instance==null)
            {
               instance = new UlogovaniKorisnik();
            }
           return instance;
      }
   
   }
}