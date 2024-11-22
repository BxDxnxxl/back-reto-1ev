using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using models;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalaController : ControllerBase
    {

        // Método para obtener todas las salas
        [HttpGet]
        public ActionResult<IEnumerable<Sala>> GetSalas()
        {
            return Ok(DataStore.Salas);
        }

        // Método para obtener una sala por ID
        [HttpGet("{id}")]
        public ActionResult<Sala> GetSala(int id)
        {
            var sala = DataStore.Salas.FirstOrDefault(s => s.Id == id);
            if (sala == null)
            {
                return NotFound($"No se encontró una sala con el ID {id}.");
            }
            return Ok(sala);
        }

        // Método para crear una nueva sala
        [HttpPost]
        public ActionResult<Sala> CreateSala(Sala sala)
        {
            DataStore.Salas.Add(sala);
            return CreatedAtAction(nameof(GetSala), new { id = sala.Id }, sala);
        }

        // Método para actualizar una sala
        [HttpPut("{id}")]

        // Método para eliminar una sala
        [HttpDelete("{id}")]
        public IActionResult DeleteSala(int id)
        {
            var sala = DataStore.Salas.FirstOrDefault(s => s.Id == id);
            if (sala == null)
            {
                return NotFound();
            }

            DataStore.Salas.Remove(sala);
            return NoContent();
        }

        // Método para filtrar salas por tipo
        [HttpGet("tipo/{tipo}")]
        public ActionResult<IEnumerable<Sala>> GetSalasPorTipo(string tipo)
        {
            var salasFiltradas = new List<Sala>();

            foreach (var sala in DataStore.Salas)
            {
                if (sala.Tipo.Contains(tipo))
                {
                    salasFiltradas.Add(sala);
                }
            }

            if (salasFiltradas.Count == 0)
            {
                return NotFound();
            }

            return Ok(salasFiltradas);
        }

    }
}
