using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using models;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SesionController : ControllerBase
    {

        // Método para obtener todas las sesiones
        [HttpGet]
        public ActionResult<IEnumerable<Sesion>> GetSesiones()
        {
            return Ok(DataStore.Sesiones);
        }

        // Método para obtener una sesion por ID
        [HttpGet("{id}")]
        public ActionResult<Sesion> GetSesion(int id)
        {
            var sesion = DataStore.Sesiones.FirstOrDefault(s => s.Id == id);
            if (sesion == null)
            {
                return NotFound($"No se encontró una sala con el ID {id}.");
            }
            return Ok(sesion);
        }

        // Método para crear una nueva sesion
        [HttpPost]
        public ActionResult<Sesion> CreateSesion(Sesion sesion)
        {
            DataStore.Sesiones.Add(sesion);
            return CreatedAtAction(nameof(GetSesion), new { id = sesion.Id }, sesion);
        }

        // Método para actualizar una sesion
        [HttpPut("{id}")]




        // Método para eliminar una sesion
        [HttpDelete("{id}")]
        public IActionResult DeleteSesion(int id)
        {
            var sesion = DataStore.Sesiones.FirstOrDefault(s => s.Id == id);
            if (sesion == null)
            {
                return NotFound();
            }

            DataStore.Sesiones.Remove(sesion);
            return NoContent();
        }

    }
}
