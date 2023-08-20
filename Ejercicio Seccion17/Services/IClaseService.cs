using Ejercicio_Seccion17.Models;
using System.Collections.Generic;

namespace Ejercicio_Seccion17.Services
{
    public interface IClaseService
    {
        void AddClase(Clase clase);
        void DeleteClase(int claseId);
        void DeleteClase(Clase clase);
        List<Clase> GetClases();
        Clase GetClase(int claseId);
        Clase UpdateClase(Clase clase);
        void DeleteClases();
    }
}
