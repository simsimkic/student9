// File:    KomentarRepository.cs
// Created: 03 May 2020 20:26:47
// Purpose: Definition of Class KomentarRepository

using System;
using System.Collections.Generic;
using Model;
using Service;

namespace Repository
{
   public class KomentarRepository
   {
      public List<Komentar> NadjiSveKomentare()
      {
         throw new NotImplementedException();
      }
      
      public Komentar Kreiraj(Komentar komentar)
      {
         throw new NotImplementedException();
      }
      
      public void Obrisi(Komentar komentar)
      {
         throw new NotImplementedException();
      }
      
      public KomentarService komentarService;
   
   }
}