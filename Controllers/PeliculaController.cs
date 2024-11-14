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

    //creación de lista de peliculas en las que almacenaremos los datos que se manejan en la API sustituyendo la bbdd
    private static List<Pelicula> peliculas = new List<Pelicula>();

    //funcion de creacion de peliculas que se usan para añadir a la lista creada anteriormente
    public static void InicializarDatos()
    {
        peliculas.Add(new Pelicula("Inception", "Un thriller de ciencia ficción", "Christopher Nolan", new[] { "Acción", "Aventura" }, new DateTime(2010, 7, 16),
            "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg","140"));
        
        peliculas.Add(new Pelicula("The Matrix", "Una historia ciberpunk revolucionaria", "Lana Wachowski y Lilly Wachowski", new[] { "Acción", "Ciencia Ficción" }, new DateTime(1999, 3, 31),
            "https://m.media-amazon.com/images/I/613ypTLZHsL.jpg", "136"));
        
        peliculas.Add(new Pelicula("Interstellar", "Exploración de los límites del espacio y el tiempo", "Christopher Nolan", new[] { "Aventura", "Ciencia Ficción" }, new DateTime(2014, 11, 7),
            "https://m.media-amazon.com/images/M/MV5BZjdkOTU3MDktZGVlOC00M2QzLTkxN2EtZWE0ZmRjZTg5ZDJhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_FMjpg_UX1000_.jpg", "169"));

    }


    //metodo que devuelve todas las peliculas
    [HttpGet]
    public ActionResult<IEnumerable<Pelicula>> GetPeliculas()
    {
        return Ok(peliculas);
    }


    //metodo que busca una pelicula por id
    [HttpGet("{id}")]
    public ActionResult<Pelicula> GetPelicula(int id)
    {
        var pelicula = peliculas.FirstOrDefault(p => p.Id == id);
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
        peliculas.Add(pelicula);
        return CreatedAtAction(nameof(GetPelicula), new { id = pelicula.Id }, pelicula);
    }


    //metodo para actualizar una pelicula
    [HttpPut("{id}")]
    public IActionResult UpdatePelicula(int id, Pelicula peliculaActualizada)
    {
        //busca el id de la pelicula y comprueba que existe
        var pelicula = peliculas.FirstOrDefault(p => p.Id == id);
        if (pelicula == null)
        {
            return NotFound();
        }
        
        if (peliculaActualizada.Nombre != "string")
        {
            pelicula.Nombre = peliculaActualizada.Nombre;
        }

        if (peliculaActualizada.Descripcion != "string")
        {
            pelicula.Descripcion = peliculaActualizada.Descripcion;
        }

        if (peliculaActualizada.Director != "string")
        {
            pelicula.Director = peliculaActualizada.Director;
        }

        if (peliculaActualizada.Categorias != null)
        {
            pelicula.Categorias = peliculaActualizada.Categorias;
        }

        if (peliculaActualizada.AnioDeSalida != default(DateTime))
        {
            pelicula.AnioDeSalida = peliculaActualizada.AnioDeSalida;
        }

        if (peliculaActualizada.ImagenUrl  != "string")
        {
            pelicula.ImagenUrl = peliculaActualizada.ImagenUrl;
        }

        if (peliculaActualizada.Duracion != "string")
        {
            pelicula.Duracion = peliculaActualizada.Duracion;
        }
            return NoContent();
        }

    //metodo para borrar una pelicula
    [HttpDelete("{id}")]
    public IActionResult DeletePelicula(int id)
    {
        //busca la pelicula por id y comprueba que exista
        var pelicula = peliculas.FirstOrDefault(p => p.Id == id);
        if (pelicula == null)
        {
            return NotFound();
        }
        //si ha encontrado la pelicula, la borra de la lista
        peliculas.Remove(pelicula);
        return NoContent();
    }

    //filtrar peliculas por categorias
    [HttpGet("categoria/{categoria}")]
    public ActionResult<IEnumerable<Pelicula>> GetPeliculasPorCategoria(string categoria)
    {
        //lista que alamcenará ñas peliculas filtradas
        var peliculasFiltradas = new List<Pelicula>();

        // con el foreach se comprobará cada pelicula existente si contiene las categorias
        foreach (var pelicula in peliculas)
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