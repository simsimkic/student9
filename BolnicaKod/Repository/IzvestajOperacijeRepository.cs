// File:    IzvestajOperacijeRepository.cs
// Created: 22 May 2020 10:45:25
// Purpose: Definition of Class IzvestajOperacijeRepository

using System;
using Model;
using Service;

namespace Repository
{
   public class IzvestajOperacijeRepository
   {
      public Model.Izvestaj.IzvestajOperacije Kreiraj(Model.Izvestaj.IzvestajOperacije izvestajOperacije)
      {
         throw new NotImplementedException();
      }
      
      public IzvestajOperacijeService izvestajOperacijeService;
   
   }
}