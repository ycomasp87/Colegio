using Ejercicio_Seccion17.Contexto;
using Ejercicio_Seccion17.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_Seccion17.Services
{
    public class AlumnoService : IAlumnoService
    {
        private readonly IContextDB _contextDB;

        public AlumnoService(IContextDB contextDB)
        {
            _contextDB = contextDB;
        }

        public void AddAlumno(Alumno alumno)
        {
            _contextDB.Alumno.Add(alumno);
            _contextDB.SaveChanges();
        }

        public void DeleteAlumno(int alumnoId)
        {
            var alumno = GetAlumno(alumnoId);
            if (alumno != null)
            {
                _contextDB.Alumno.Remove(alumno);
                _contextDB.SaveChanges();
            }
        }

        public void DeleteAlumno(Alumno alumno)
        {
            _contextDB.Alumno.Remove(alumno);
            _contextDB.SaveChanges();
        }

        public List<Alumno> GetAlumnos()
        {
            return _contextDB.Alumno.Select(x => x).ToList();
        }

        public Alumno GetAlumno(int alumnoId)
        {
            return _contextDB.Alumno.Where(x => x.AlumnoId == alumnoId).FirstOrDefault();
        }

        public Alumno UpdateAlumno(Alumno alumno)
        {
            var alumnoAux = _contextDB.Alumno.Update(alumno).Entity;
            _contextDB.SaveChanges();
            return alumnoAux;
        }

        public void DeleteAlumnos()
        {
            _contextDB.Alumno.RemoveRange(GetAlumnos());
            _contextDB.SaveChanges();
        }

    }
}
