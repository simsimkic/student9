// File:    RadoviController.cs
// Created: 25 May 2020 14:09:42
// Purpose: Definition of Class RadoviController

using System;
using Model;

namespace Controller
{
   public class RadoviController
   {
      public Renoviranje KreirajRenoviranje(Renoviranje renoviranje)
      {
         return renoviranjeService.Kreiraj(renoviranje);
      }
      
      public void ObrisiRenoviranje(Renoviranje renoviranje)
      {
         renoviranjeService.Obrisi(renoviranje);
      }
      
      public void IzmeniRenoviranje(Renoviranje renoviranje)
      {
         renoviranjeService.Izmeni(renoviranje);
      }
      
      public PremestanjeInventara KreirajPremestanjeInventara(PremestanjeInventara premestanjeInventara)
      {
         return premestanjeInventaraService.Kreiraj(premestanjeInventara);
      }
      
      public void ObrisiPremestanjeInventara(PremestanjeInventara premestanjeInventara)
      {
         premestanjeInventaraService.Obrisi(premestanjeInventara);
      }
      
      public void IzmeniPremestanjeInventara(PremestanjeInventara premestanjeInventara)
      {
         premestanjeInventaraService.Izmeni(premestanjeInventara);
      }
      
      public Service.RenoviranjeService renoviranjeService;
      public Service.PremestanjeInventaraService premestanjeInventaraService;
   
   }
}