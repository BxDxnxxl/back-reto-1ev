using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using models;
using System.Reflection;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompraController : ControllerBase
    {

    //metodo que devuelve todas las peliculas
    [HttpGet]
    public ActionResult<IEnumerable<Compra>> GetCompras()
    {
        return Ok(DataStore.Compras);
    }

    [HttpGet("{id}")]
        public ActionResult<Compra> GetCompra(int id)
        {
            var compra = DataStore.Compras.FirstOrDefault(c => c.Id == id);
            if (compra == null)
            {
                return NotFound();
            }
            return Ok(compra);
        }

    //metodo para insertar una pelicula a la lista de peliculas
    [HttpPost]
    public ActionResult<Compra> CreatePelicula(Compra compra)
    {
        DataStore.Compras.Add(compra);
        return CreatedAtAction(nameof(GetCompra), new { id = compra.Id }, compra);
    }


    }
}