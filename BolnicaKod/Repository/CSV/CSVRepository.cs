using bolnica.Exception;
using bolnica.Repository.Abstract;
using bolnica.Repository.CSV.Stream;
using bolnica.Repository.Sequencer;
using System;
using System.Collections.Generic;
using System.Linq;


namespace bolnica.Repository.CSV
{
    public class CSVRepository<E, ID> : IRepository<E, ID>
        where E : IIdentifiable<ID>
        where ID : IComparable
    {
        private const string NOT_FOUND_ERROR = "{0} with {1}:{2} can not be found!";

        protected string _imeEntitet;
        protected ICSVStream<E> _stream;
        protected ISequencer<ID> _sequencer;
        public CSVRepository(string imeEntitet, ICSVStream<E> stream)
        {
            _imeEntitet = imeEntitet;
            _stream = stream;
            InicijalizujId();
        }
        public CSVRepository(string imeEntitet, ICSVStream<E> stream, ISequencer<ID> sequencer)
        {
            _imeEntitet = imeEntitet;
            _stream = stream;
            _sequencer = sequencer;
            InicijalizujId();
        }

        public IEnumerable<E> NadjiSve() => _stream.CitajSve();
        public void Izmeni(E entitet)
        {
            try
            {
                var entiteti = _stream.CitajSve().ToList();
                entiteti[entiteti.FindIndex(ent => ent.GetId().CompareTo(entitet.GetId()) == 0)] = entitet;
                _stream.SacuvajSve(entiteti);
                
            }
            catch(ArgumentException)
            {
                throw new EntityNotFoundException( "entitet nije izmenjen");
            }
        }

        public E KreirajBezSekvencera(E entitet)
        {
            _stream.DodajNaKrajFajla(entitet);
            return entitet;
        }

        public E Kreiraj(E entitet)
        {
            entitet.SetId(_sequencer.GenerisiId());
            _stream.DodajNaKrajFajla(entitet);
            return entitet;
        }

        public IEnumerable<E> Nadji(Func<E, bool> predikat) => _stream.CitajSve().Where(predikat);

        public E NadjiPoId(ID id)
        {
            try
            {
                return _stream.CitajSve().SingleOrDefault(entitet => entitet.GetId().CompareTo(id) == 0);
            }
            catch(ArgumentException)
            {
                throw new EntityNotFoundException(string.Format(NOT_FOUND_ERROR, _imeEntitet, "id", id));
            }
        }

        public void Obrisi(E entitet)
        {
            var entiteti = _stream.CitajSve().ToList();
            var entitetZaUklanjanje = entiteti.SingleOrDefault(ent => ent.GetId().CompareTo(entitet.GetId()) == 0);
            if (entitetZaUklanjanje != null)
            {
                entiteti.Remove(entitetZaUklanjanje);
                _stream.SacuvajSve(entiteti);
            }
            else
            {
                ThrowEntityNotFoundException("id", entitet.GetId());
            }
        }



        private void ThrowEntityNotFoundException(string key, object value)
          => throw new EntityNotFoundException(string.Format(NOT_FOUND_ERROR, _imeEntitet, key, value));

        protected void InicijalizujId() => _sequencer.Inicijalizuj(MaxId(_stream.CitajSve()));

        private ID MaxId(IEnumerable<E> entiteti)
          => entiteti.Count() == 0 ? default : entiteti.Max(entitet => entitet.GetId());
    }
}
