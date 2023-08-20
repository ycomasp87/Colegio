namespace Ejercicio_Seccion17.Models
{
    public class Alumno
    {
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public Clase Clase { get; set; }
        public int ClaseId { get; set; }
    }
}
