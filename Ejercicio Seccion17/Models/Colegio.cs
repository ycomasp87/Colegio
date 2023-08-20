using System.Collections.Generic;

namespace Ejercicio_Seccion17.Models
{
    public class Colegio
    {
        
        public int ColegioId { get; set; }
        
        public string Nombre { get; set; }
        
        public List<Clase> Clases { get; set; }
        
    }
}
