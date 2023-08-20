using Ejercicio_Seccion17.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ejercicio_Seccion17.EntityConfig
{
    public class AlumnoEntityConfig
    {
        public static void setAlumnoEntityConfig(EntityTypeBuilder<Alumno> entityBuilder)
        {
            entityBuilder.HasKey(x => x.AlumnoId);
            entityBuilder.Property(x => x.Nombre).IsRequired();
            entityBuilder.Property(x => x.Nombre).HasMaxLength(64);
        }

    }
}
