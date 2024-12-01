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

        [HttpGet("Pelicula/{idPelicula}/Sesiones")]
        public ActionResult<Sesion> GetSesionesPelicula(int idPelicula)
        {
            var sesiones = DataStore.Sesiones.Where(s => s.Pelicula.Id == idPelicula).ToList();
            if (sesiones == null)
            {
                return NotFound();
            }
            return Ok(sesiones);
        }

        [HttpPut("{idSesion}/actualizarAsientos/")]
        public IActionResult ActualizarAsientos(int idSesion, [FromBody] List<int> asientosIds)
        {
            var sesion = DataStore.Sesiones.FirstOrDefault(s => s.Id == idSesion);

            try
            {
                foreach (var idAsiento in asientosIds)
                {
                    var asiento = sesion.ListaAsientos.FirstOrDefault(a => a.Id == idAsiento);

                    asiento.Ocupado = true; // Cambiar el estado del asiento a ocupado
                }

                sesion.EliminarAsientos(asientosIds.Count);

                return Ok($"Asientos actualizados correctamente en la sesión con ID {idSesion}.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar los asientos: {ex.Message}");
            }
        }

        [HttpPut("{idSesion}/liberarAsientos/")]
        public IActionResult LiberarAsientos(int idSesion, [FromBody] List<int> asientosIds)
        {
            var sesion = DataStore.Sesiones.FirstOrDefault(s => s.Id == idSesion);

            try
            {
                foreach (var idAsiento in asientosIds)
                {
                    var asiento = sesion.ListaAsientos.FirstOrDefault(a => a.Id == idAsiento);

                    asiento.Ocupado = false; // Cambiar el estado del asiento a no ocupado
                }

                sesion.EliminarAsientos(asientosIds.Count);

                return Ok($"Asientos actualizados correctamente en la sesión con ID {idSesion}.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar los asientos: {ex.Message}");
            }
        }

    }
}
