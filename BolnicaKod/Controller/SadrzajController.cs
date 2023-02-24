// File:    SadrzajController.cs
// Created: 02 May 2020 23:19:39
// Purpose: Definition of Class SadrzajController

using System;
using Model;
using bolnica.Service;

namespace Controller
{
   public class SadrzajController
   {
        private readonly IService<Clanak, int> _serviceClanak;
        private readonly IService<Komentar, int> _serviceKomentar;
        private readonly IService<Feedback, int> _serviceFeedback;
        private readonly IService<Notifikacija, int> _serviceNotifikacija;

        public SadrzajController(IService<Clanak,int> serviceClanak, IService<Komentar,int> serviceKomentar, IService<Feedback,int> serviceFeedback, IService<Notifikacija, int> serviceNotifikacija)
        {
            _serviceClanak = serviceClanak;
            _serviceKomentar = serviceKomentar;
            _serviceFeedback = serviceFeedback;
            _serviceNotifikacija = serviceNotifikacija;
        }
      
      
      public Model.Notifikacija KreirajNotifikaciju(Model.Notifikacija notifikacija)
      {
         return _serviceNotifikacija.Kreiraj(notifikacija);
      }
      
      public Komentar KreirajKomentar(Komentar komentar)
      {
         return _serviceKomentar.Kreiraj(komentar);
      }
      
      public void ObrisiKomentar(Komentar komentar)
      {
         _serviceKomentar.Obrisi(komentar);
      }
      
      public Clanak KreirajClanak(Clanak clanak)
      {
         return _serviceClanak.Kreiraj(clanak);
      }
      
      public void ObrisiClanak(Clanak clanak)
      {
         _serviceClanak.Obrisi(clanak);
      }
      
      public Model.Feedback KreirajFeedback(Model.Feedback feedback)
      {
         return _serviceFeedback.Kreiraj(feedback);
      }
   
   }
}