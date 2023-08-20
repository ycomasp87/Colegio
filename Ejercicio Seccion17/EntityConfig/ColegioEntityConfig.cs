using Ejercicio_Seccion17.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ejercicio_Seccion17.EntityConfig
{
    public class ColegioEntityConfig
    {

        public static void setColegioEntityConfig(EntityTypeBuilder<Colegio> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ColegioId);
            entityBuilder.Property(x => x.Nombre).IsRequired();
            entityBuilder.Property(x => x.Nombre).HasMaxLength(150);

        }
    }
}
