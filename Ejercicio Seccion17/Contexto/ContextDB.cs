using Ejercicio_Seccion17.EntityConfig;
using Ejercicio_Seccion17.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio_Seccion17.Contexto
{
    public class ContextDB : DbContext, IContextDB
    {

        public ContextDB(DbContextOptions<ContextDB> options) : base (options) 
        {
        
        }

        public DbSet<Colegio> Colegio { get; set; }
        public DbSet<Clase> Clase { get; set; }
        public DbSet<Profesor> Profesor { get; set; }
        public DbSet<Alumno> Alumno { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ColegioEntityConfig.setColegioEntityConfig(modelBuilder.Entity<Colegio>());
            ClaseEntityConfig.setClaseEntityConfig(modelBuilder.Entity<Clase>());
            ProfesorEntityConfig.setProfesorEntityConfig(modelBuilder.Entity<Profesor>());
            AlumnoEntityConfig.setAlumnoEntityConfig(modelBuilder.Entity<Alumno>());
        }

    }

    
}
