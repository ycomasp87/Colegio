using Ejercicio_Seccion17.Models;
using System.Collections.Generic;

namespace Ejercicio_Seccion17.Services
{
    public interface IAlumnoService
    {
        void AddAlumno(Alumno alumno);
        void DeleteAlumno(int alumnoId);
        void DeleteAlumno(Alumno alumno);
        List<Alumno> GetAlumnos();
        Alumno GetAlumno(int alumnoId);
        Alumno UpdateAlumno(Alumno alumno);
        void DeleteAlumnos();
    }
}
