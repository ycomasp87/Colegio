using Ejercicio_Seccion17.Models;
using System.Collections.Generic;

namespace Ejercicio_Seccion17.Services
{
    public interface IProfesorService
    {
        void AddProfesor(Profesor profesor);
        void DeleteProfesor(int profesorId);
        void DeleteProfesor(Profesor profesor);
        List<Profesor> GetProfesores();
        Profesor GetProfesor(int profesorId);
        Profesor UpdateProfesor(Profesor profesor);

        void DeleteProfesores();

    }
}
