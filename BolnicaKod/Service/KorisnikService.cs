// File:    KorisnikService.cs
// Created: 02 May 2020 21:45:08
// Purpose: Definition of Class KorisnikService

using System;
using System.Collections.Generic;
using bolnica.Exception;
using Repository;
using bolnica.Repository.Abstract;
using bolnica.Service;
using Model;

namespace Service
{
   public class KorisnikService : IService<Korisnik, string>
   {
      

      private readonly RegistrovaniKorisnikRepository registrovaniKorisnikRepository;
        private readonly IRegistrovaniKorisnikRepository _korisnikRepozitory;
        private const string NE_POSTOJI = "Korisnik sa ovim kredencijalima ne postoji";

        public KorisnikService(IRegistrovaniKorisnikRepository korisnikRepository)
        {
            _korisnikRepozitory = korisnikRepository;
      
        }
        public bool DaLiJeSpecijalista(Korisnik korisnik)
        {
            throw new NotImplementedException();
        }

        public void Izmeni(Korisnik entitet)
        {
            _korisnikRepozitory.Izmeni(entitet);
        }

        public bool KorisnickoImeValidno(string korisnickoIme)
        {
            throw new NotImplementedException();
        }

        public Korisnik Kreiraj(Korisnik entitet)
        {
            return _korisnikRepozitory.Kreiraj(entitet);
        }

        public Korisnik Logovanje(string korisnickoIme, string lozinka)
        {
            Korisnik korisnik = _korisnikRepozitory.NadjiPoKorisnickomImenuILozinki(korisnickoIme, lozinka);


            if (korisnik == null)
                throw new EntityNotFoundException(NE_POSTOJI);
            else
            {
                korisnik.Ulogovan = true;
                _korisnikRepozitory.Izmeni(korisnik);
                return korisnik;
            }
        }

        public bool LozinkaValidna(string lozinka)
        {
            throw new NotImplementedException();
        }

        public List<Korisnik> NadjiLekare()
        {
            //return registrovaniKorisnikRepository.NadjiPoUlozi(Uloga.lekar);
            throw new NotImplementedException();
        }

        public Korisnik NadjiPoId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Korisnik> NadjiSve()
        {
            return registrovaniKorisnikRepository.NadjiSveRegistrovaneKorisnike();
        }

        public void Obrisi(Korisnik entitet)
        {
            registrovaniKorisnikRepository.Obrisi(entitet);
        }

        public void Odjava(string korisnickoIme)
        {
            Korisnik korisnik = registrovaniKorisnikRepository.NadjiPoKorisnickomImenu(korisnickoIme);

            korisnik.Ulogovan = false;
            registrovaniKorisnikRepository.Izmeni(korisnik);
        }

        public bool DaLiJeUlogovan(Korisnik korisnik)
        {
            if (korisnik.Ulogovan)
                return true;
            else
                return false;
        }
    }
}