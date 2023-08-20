using Ejercicio_Seccion17.Models;
using Ejercicio_Seccion17.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio_Seccion17.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IColegioService _colegioService;
        private readonly IClaseService _claseService;
        private readonly IAlumnoService _alumnoService;
        private readonly IProfesorService _profesorService;
        public ValuesController(IColegioService colegioService, IClaseService claseService, IAlumnoService alumnoService, IProfesorService profesorService) 
        { 
            _colegioService = colegioService;
            _claseService = claseService;
            _alumnoService = alumnoService;
            _profesorService = profesorService;
            
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _colegioService.DeleteColegios();
            _colegioService.AddColegio(new Models.Colegio
            {
                Nombre = "Colegio San José"
            });
            _colegioService.AddColegio(new Models.Colegio
            {
                Nombre = "Colegio Santa María"
            });

            var profesor1 = new Profesor
            {
                Nombre = "Juan Pérez"
            };
            var profesor2 = new Profesor
            {
                Nombre = "Alberto Díaz"
            };

            var alumno1 = new Alumno
            {
                Nombre = "Alumno 1"
            };

            var alumno2 = new Alumno
            {
                Nombre = "Alumno 2"
            };   
            

            // Crear objetos de ejemplo para Clases
            var clase1 = new Clase
            {
                Nombre = "Clase 1",
                Profesor = profesor1,
                Alumnos = new List<Alumno> { alumno1 }
            };

            var clase2 = new Clase
            {
                Nombre = "Clase 2",
                Profesor = profesor2,
                Alumnos = new List<Alumno> { alumno2 }
            };

            _alumnoService.AddAlumno(alumno1);
            _alumnoService.AddAlumno( alumno2);
            _profesorService.AddProfesor(profesor1);
            _profesorService.AddProfesor( profesor2);
            _claseService.AddClase(clase1);
            _claseService.AddClase( clase2);

            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
