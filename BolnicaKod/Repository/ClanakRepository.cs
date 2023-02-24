// File:    ClanakRepository.cs
// Created: 03 May 2020 20:27:02
// Purpose: Definition of Class ClanakRepository

using System;
using System.Collections.Generic;
using Model;
using Service;

namespace Repository
{
   public class ClanakRepository
   {
      public List<Clanak> NadjiSveClanke()
      {
         throw new NotImplementedException();
      }
      
      public Clanak NadjiPoLekaru(Lekar lekar)
      {
         throw new NotImplementedException();
      }
      
      public Clanak NadjiPoId(int id)
      {
         throw new NotImplementedException();
      }
      
      public ClanakService clanakService;
   
   }
}