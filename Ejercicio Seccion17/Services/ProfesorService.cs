using Ejercicio_Seccion17.Contexto;
using Ejercicio_Seccion17.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_Seccion17.Services
{
    public class ProfesorService : IProfesorService
    {
        private readonly IContextDB _contextDB;

        public ProfesorService(IContextDB contextDB)
        {
            _contextDB = contextDB;
        }

        public void AddProfesor(Profesor profesor)
        {
            _contextDB.Profesor.Add(profesor);
            _contextDB.SaveChanges();
        }

        public void DeleteProfesor(int profesorID)
        {
            var profesor = GetProfesor(profesorID);
            _contextDB.Profesor.Remove(profesor);
            _contextDB.SaveChanges();
        }

        public void DeleteProfesor(Profesor profesor)
        {
            _contextDB.Profesor.Remove(profesor);
        }

        public void DeleteProfesores()
        {
            _contextDB.Profesor.RemoveRange(GetProfesores());
            _contextDB.SaveChanges();
        }

        public Profesor GetProfesor(int profesorId)
        {
            return _contextDB.Profesor.Where(x => x.ProfesorId == profesorId).FirstOrDefault();
        }

        public List<Profesor> GetProfesores()
        {
            return _contextDB.Profesor.Select(x => x).ToList();
        }

        public Profesor UpdateProfesor(Profesor profesor)
        {
            var profesorAux = _contextDB.Profesor.Update(profesor).Entity;
            _contextDB.SaveChanges();
            return profesorAux;
        }


    }
}
