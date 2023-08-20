using Ejercicio_Seccion17.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio_Seccion17.Contexto
{
    public interface IContextDB
    {
        DbSet<Colegio> Colegio { get; set; }
        DbSet<Clase> Clase { get; set; }
        DbSet<Profesor> Profesor { get; set; }
        DbSet<Alumno> Alumno { get; set; }
        int SaveChanges();

    }
}
