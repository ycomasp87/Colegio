using Ejercicio_Seccion17.Contexto;
using Ejercicio_Seccion17.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_Seccion17.Services
{
    public class ClaseService : IClaseService
    {
        private readonly IContextDB _contextDB;

        public ClaseService(IContextDB contextDB)
        {
            _contextDB = contextDB;
        }


        public void AddClase(Clase clase)
        {
            _contextDB.Clase.Add(clase);
            _contextDB.SaveChanges();
        }

        public void DeleteClase(int claseId)
        {
            var clase = GetClase(claseId);
            _contextDB.Clase.Remove(clase);
        }

        public void DeleteClase(Clase clase)
        {
            _contextDB.Clase.Remove(clase);
        }

        public Clase GetClase(int claseId)
        {
            return _contextDB.Clase.Where(x => x.ClaseId == claseId).FirstOrDefault();
        }

        public List<Clase> GetClases()
        {
            return _contextDB.Clase.Select(x => x).ToList();
        }

        public Clase UpdateClase(Clase clase)
        {
            var claseAux = _contextDB.Clase.Update(clase).Entity;
            _contextDB.SaveChanges();
            return claseAux;
        }
        public void DeleteClases()
        {
            _contextDB.Clase.RemoveRange(GetClases());
            _contextDB.SaveChanges();
        }
    }
}
