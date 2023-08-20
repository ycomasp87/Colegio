using Ejercicio_Seccion17.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ejercicio_Seccion17.EntityConfig
{
    public class ProfesorEntityConfig
    {

        public static void setProfesorEntityConfig(EntityTypeBuilder<Profesor> entityBuilder)
        {
            entityBuilder.HasKey(x=> x.ProfesorId);
            entityBuilder.Property(x => x.Nombre).IsRequired();
            entityBuilder.Property(x => x.Nombre).HasMaxLength(150);
        }
    }
}
