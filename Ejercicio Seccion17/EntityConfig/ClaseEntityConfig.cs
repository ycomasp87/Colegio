using Ejercicio_Seccion17.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ejercicio_Seccion17.EntityConfig
{
    public class ClaseEntityConfig
    {
        public static void setClaseEntityConfig(EntityTypeBuilder<Clase> entityBuilder )
        {
            entityBuilder.HasKey( x => x.ClaseId );
            entityBuilder.Property(x => x.Nombre).IsRequired();
            entityBuilder.Property(x => x.Nombre).HasMaxLength(100);

        }
    }
}
