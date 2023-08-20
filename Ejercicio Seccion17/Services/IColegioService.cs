using Ejercicio_Seccion17.Models;
using System.Collections.Generic;

namespace Ejercicio_Seccion17.Services
{
    public interface IColegioService
    {
        void AddColegio(Colegio colegio);
        void DeleteColegio(int colegioId);
        void DeleteColegio(Colegio colegio);
        List<Colegio> GetColegios();
        Colegio GetColegio(int colegioId);
        Colegio UpdateColegio(Colegio colegio);
        void DeleteColegios();
    }
}
