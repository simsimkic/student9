// File:    LajkRepository.cs
// Created: 03 May 2020 20:27:20
// Purpose: Definition of Class LajkRepository

using System;
using System.Collections.Generic;
using Model;
using Model.Enum;
using Service;

namespace Repository
{
   public class LajkRepository
   {
      public Lajk Kreiraj(Lajk lajk)
      {
         throw new NotImplementedException();
      }
      
      public void Obrisi(Lajk lajk)
      {
         throw new NotImplementedException();
      }
      
      public Lajk Izmeni(Lajk lajk)
      {
         throw new NotImplementedException();
      }
      
      public List<Lajk> NadjiPoSlicici(VrstaSlicice slicica)
      {
         throw new NotImplementedException();
      }
      
      public List<Lajk> NadjiSveLajkove()
      {
         throw new NotImplementedException();
      }
      
      public LajkService lajkService;
   
   }
}