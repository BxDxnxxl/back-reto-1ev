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
    public class PeliculaController : ControllerBase
    {

    //metodo que devuelve todas las peliculas
    [HttpGet]
    public ActionResult<IEnumerable<Pelicula>> GetPeliculas()
    {
        return Ok(DataStore.Peliculas);
    }


    //metodo que busca una pelicula por id
    [HttpGet("{id}")]
    public ActionResult<Pelicula> GetPelicula(int id)
    {
        var pelicula = DataStore.Peliculas.FirstOrDefault(p => p.Id == id);
        if (pelicula == null)
        {
            return NotFound();
        }
        return Ok(pelicula);
    }

    //metodo para insertar una pelicula a la lista de peliculas
    [HttpPost]
    public ActionResult<Pelicula> CreatePelicula(Pelicula pelicula)
    {
        DataStore.Peliculas.Add(pelicula);
        return CreatedAtAction(nameof(GetPelicula), new { id = pelicula.Id }, pelicula);
    }


    //metodo para actualizar una pelicula
    [HttpPut("{id}")]
    public IActionResult UpdatePelicula(int id, Pelicula peliculaActualizada)
    {
        //busca el id de la pelicula y comprueba que existe
        var pelicula = DataStore.Peliculas.FirstOrDefault(p => p.Id == id);
        if (pelicula == null)
        {
            return NotFound();
        }
        
         if (!string.IsNullOrWhiteSpace(peliculaActualizada.Nombre))
            {
                pelicula.Nombre = peliculaActualizada.Nombre;
            }
            if (!string.IsNullOrWhiteSpace(peliculaActualizada.Descripcion))
            {
                pelicula.Descripcion = peliculaActualizada.Descripcion;
            }
            if (!string.IsNullOrWhiteSpace(peliculaActualizada.Director))
            {
                pelicula.Director = peliculaActualizada.Director;
            }
            if (peliculaActualizada.Categorias != null && peliculaActualizada.Categorias.Any())
            {
                pelicula.Categorias = peliculaActualizada.Categorias;
            }
            if (peliculaActualizada.AnioDeSalida != default(DateTime))
            {
                pelicula.AnioDeSalida = peliculaActualizada.AnioDeSalida;
            }
            if (!string.IsNullOrWhiteSpace(peliculaActualizada.ImagenBannerUrl))
            {
                pelicula.ImagenBannerUrl = peliculaActualizada.ImagenBannerUrl;
            }
            if (!string.IsNullOrWhiteSpace(peliculaActualizada.ImagenPequeniaUrl))
            {
                pelicula.ImagenPequeniaUrl = peliculaActualizada.ImagenPequeniaUrl;
            }
            /*if (!string.IsNullOrWhiteSpace(peliculaActualizada.Duracion))
            {
                pelicula.Duracion = peliculaActualizada.Duracion;
            }*/
            if (!string.IsNullOrWhiteSpace(peliculaActualizada.Valoracion))
            {
                pelicula.Valoracion = peliculaActualizada.Valoracion;
            }

            return NoContent();
        }

    //metodo para borrar una pelicula
    [HttpDelete("{id}")]
    public IActionResult DeletePelicula(int id)
    {
        //busca la pelicula por id y comprueba que exista
        var pelicula = DataStore.Peliculas.FirstOrDefault(p => p.Id == id);
        if (pelicula == null)
        {
            return NotFound();
        }
        //si ha encontrado la pelicula, la borra de la lista
        DataStore.Peliculas.Remove(pelicula);
        return NoContent();
    }

    //filtrar peliculas por categorias
    [HttpGet("categoria/{categoria}")]
    public ActionResult<IEnumerable<Pelicula>> GetPeliculasPorCategoria(string categoria)
    {
        //lista que alamcenará ñas peliculas filtradas
        var peliculasFiltradas = new List<Pelicula>();

        // con el foreach se comprobará cada pelicula existente si contiene las categorias
        foreach (var pelicula in DataStore.Peliculas)
        {
            if (pelicula.Categorias.Contains(categoria))
            {
                peliculasFiltradas.Add(pelicula);
            }
        }

        //en caso de no haber ninguna pelicula, controlamos el posible error
        if (peliculasFiltradas.Count == 0)
        {
            return NotFound($"No se encontraron películas en la categoría '{categoria}'.");
        }

        // en caso de haber peliculas que coinciden con esta categoria, las mostramos
        return Ok(peliculasFiltradas);
    }

    }
}