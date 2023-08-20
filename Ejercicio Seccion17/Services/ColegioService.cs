using Ejercicio_Seccion17.Contexto;
using Ejercicio_Seccion17.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_Seccion17.Services
{
    public class ColegioService : IColegioService
    {
        private readonly IContextDB _contextDB;

        public ColegioService(IContextDB contextDB)
        {
            _contextDB = contextDB;
        }

        public void AddColegio(Colegio colegio)
        {
            _contextDB.Colegio.Add(colegio);
            _contextDB.SaveChanges();
        }

        public void DeleteColegio(int colegioId)
        {
            var colegio = GetColegio(colegioId);
            if (colegio != null)
            {
                _contextDB.Colegio.Remove(colegio);
                _contextDB.SaveChanges();
            }

        }

        public void DeleteColegio(Colegio colegio)
        {

            _contextDB.Colegio.Remove(colegio);
            _contextDB.SaveChanges();

        }

        public List<Colegio> GetColegios()
        {

            return _contextDB.Colegio.Select(x => x).ToList();

        }

        public Colegio GetColegio(int colegioID)
        {
            return _contextDB.Colegio.Where(x => x.ColegioId == colegioID).FirstOrDefault();
        }

        public Colegio UpdateColegio(Colegio colegio)
        {
            var colegioAux = _contextDB.Colegio.Update(colegio).Entity;
            _contextDB.SaveChanges();
            return colegioAux;
        }

        public void DeleteColegios()
        {
            _contextDB.Colegio.RemoveRange(GetColegios());
            _contextDB.SaveChanges();
        }
    }
}
