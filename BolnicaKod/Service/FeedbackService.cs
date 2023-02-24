// File:    FeedbackService.cs
// Created: 25 May 2020 13:31:45
// Purpose: Definition of Class FeedbackService

using System;
using System.Collections.Generic;
using bolnica.Service;
using Model;

namespace Service
{
   public class FeedbackService : IService<Feedback, int>,
        IFeedbackService
   {
      public Feedback Kreiraj(Model.Feedback feedback)
      {
         throw new NotImplementedException();
      }

        public IEnumerable<Feedback> NadjiSve()
        {
            throw new NotImplementedException();
        }

        public Feedback NadjiPoId(int id)
        {
            throw new NotImplementedException();
        }

        public void Izmeni(Feedback entitet)
        {
            throw new NotImplementedException();
        }

        public void Obrisi(Feedback entitet)
        {
            throw new NotImplementedException();
        }

        public Repository.FeedbackRepository feedbackRepository;
   
   }
}