using System.Collections.Generic;

namespace Ejercicio_Seccion17.Models
{
    public class Clase
    {
        public int ClaseId { get; set; }
        public string Nombre { get; set; }
        public Profesor Profesor { get; set; }
        public int ProfesorId { get; set; }
        public List<Alumno> Alumnos { get; set; }

    }
}
