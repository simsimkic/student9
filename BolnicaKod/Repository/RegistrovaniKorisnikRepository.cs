// File:    RegistrovaniKorisnikRepository.cs
// Created: 03 May 2020 20:09:50
// Purpose: Definition of Class RegistrovaniKorisnikRepository

using System;
using System.Collections.Generic;
using System.Linq;
using bolnica.Exception;
using bolnica.Repository.Abstract;
using bolnica.Repository.CSV;
using bolnica.Repository.CSV.Stream;
using bolnica.Repository.Sequencer;
using Model;
using Model.Enum;
using Service;

namespace Repository
{

    public class RegistrovaniKorisnikRepository : CSVRepository<Korisnik, string>, IRegistrovaniKorisnikRepository, IEagerCSVRepository<Korisnik, string>
        
   {
        private const string IME_ENTITETA = "Korisnik";
        private const string VEC_POSTOJI = "Korisnicko ime {0} vec postoji!";

        public RegistrovaniKorisnikRepository(ICSVStream<Korisnik> stream) :base(IME_ENTITETA, stream)
        {
        }
        public new IEnumerable<Korisnik> Nadji(Func<Korisnik, bool> predicate) => NadjiSve().Where(predicate);
    
        public new Korisnik Kreiraj(Korisnik korisnik)
        {
            if (jedinstvenoKorIme(korisnik.KorisnickoIme))
                return base.Kreiraj(korisnik);
            else
                throw new VecPostojiException(string.Format(VEC_POSTOJI, korisnik.KorisnickoIme));
        }
      
      
      
      public Korisnik NadjiPoKorisnickomImenuILozinki(String korIme, String lozinka)
      {
            var korisnici = NadjiSve();
            return korisnici.SingleOrDefault(korisnik => korisnik.KorisnickoIme == korIme && korisnik.Lozinka == lozinka);
      }
      
      public List<Korisnik> NadjiPoUlozi(Uloga uloga)
      {
            var korisnici = Nadji(korisnik => korisnik.Uloga == uloga);
            return korisnici.ToList();
      }

        public IEnumerable<Korisnik> NadjiSveRegistrovaneKorisnike()
        {
            return NadjiSve();
        }
        
        public Korisnik NadjiPoKorisnickomImenu(string korisnickoIme)
        {
            var korisnik = NadjiPoId(korisnickoIme);
            return korisnik;
        }


        public Korisnik VratiEager(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Korisnik> VratiSveEager()
        {
            throw new NotImplementedException();
        }


        private bool jedinstvenoKorIme(string korIme) 
            => NadjiPoKorisnickomImenu(korIme) == null;

        public KorisnikService korisnikService;
   
   }
}