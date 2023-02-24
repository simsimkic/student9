// File:    KartonRepository.cs
// Created: 18 May 2020 21:44:08
// Purpose: Definition of Class KartonRepository

using System;
using Model;
using Service;

namespace Repository
{
   public class KartonRepository
   {
      public Model.Karton NadjiPoKorisniku(Model.Korisnik korisnik)
      {
         throw new NotImplementedException();
      }
      
      public Model.Karton Izmeni(Model.Karton karton)
      {
         throw new NotImplementedException();
      }
      
      public Model.Karton Kreiraj(Model.Karton karton)
      {
         throw new NotImplementedException();
      }
      
      public KartonService kartonService;
   
   }
}