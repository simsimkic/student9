// File:    Feedback.cs
// Created: 25 May 2020 13:17:54
// Purpose: Definition of Class Feedback

using System;

namespace Model
{
   public class Feedback : Sadrzaj
   {
        public Feedback(int id, string tekst, Korisnik autor)
            :base (id, tekst, autor)
        {

        }
   }
}