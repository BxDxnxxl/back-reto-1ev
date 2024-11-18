using models;
using System;
using System.Collections.Generic;

public static class InicializadorDatos
{
    public static void InicializarDatos()
    {
        InicializarPeliculas();
        InicializarSalas();
        InicializarSesiones();
        InicializarButacas();
    }

    private static void InicializarPeliculas()
    {
        DataStore.Peliculas.AddRange(new List<Pelicula>
        {
            new Pelicula(
                nombre: "Vengadores: Infinity War",
                descripcion: "Los Vengadores intentan detener a Thanos antes de que destruya la mitad del universo.",
                director: "Anthony y Joe Russo",
                categorias: new[] { "Acción", "Ciencia Ficción", "Superhéroes" },
                anioDeSalida: new DateTime(2018, 4, 27),
                imagenBannerUrl: "https://example.com/infinitywar-banner.jpg",
                imagenPequeniaUrl: "https://example.com/infinitywar-small.jpg",
                duracion: "2h 40m",
                valoracion: "8.5"
            ),
            new Pelicula(
                nombre: "Cómo entrenar a tu dragón 3",
                descripcion: "Hipo y Desdentao enfrentan nuevos desafíos mientras buscan un mundo escondido para los dragones.",
                director: "Dean DeBlois",
                categorias: new[] { "Animación", "Fantasía", "Aventura" },
                anioDeSalida: new DateTime(2019, 2, 22),
                imagenBannerUrl: "https://example.com/dragons3-banner.jpg",
                imagenPequeniaUrl: "https://example.com/dragons3-small.jpg",
                duracion: "1h 45m",
                valoracion: "8.0"
            ),
            new Pelicula(
                nombre: "Halloween (2018)",
                descripcion: "Laurie Strode se enfrenta nuevamente a Michael Myers en este reinicio de la franquicia.",
                director: "David Gordon Green",
                categorias: new[] { "Terror", "Suspenso" },
                anioDeSalida: new DateTime(2018, 10, 19),
                imagenBannerUrl: "https://example.com/halloween2018-banner.jpg",
                imagenPequeniaUrl: "https://example.com/halloween2018-small.jpg",
                duracion: "1h 45m",
                valoracion: "7.0"
            ),
            new Pelicula(
                nombre: "Halloween Kills",
                descripcion: "Michael Myers continúa su masacre mientras Haddonfield decide luchar contra él.",
                director: "David Gordon Green",
                categorias: new[] { "Terror", "Suspenso" },
                anioDeSalida: new DateTime(2021, 10, 15),
                imagenBannerUrl: "https://example.com/halloweenkills-banner.jpg",
                imagenPequeniaUrl: "https://example.com/halloweenkills-small.jpg",
                duracion: "1h 45m",
                valoracion: "6.5"
            ),
            new Pelicula(
                nombre: "Halloween Ends",
                descripcion: "Laurie Strode se enfrenta a Michael Myers por última vez en un enfrentamiento épico.",
                director: "David Gordon Green",
                categorias: new[] { "Terror", "Suspenso" },
                anioDeSalida: new DateTime(2022, 10, 14),
                imagenBannerUrl: "https://example.com/halloweenends-banner.jpg",
                imagenPequeniaUrl: "https://example.com/halloweenends-small.jpg",
                duracion: "1h 50m",
                valoracion: "6.0"
            ),
            new Pelicula(
                nombre: "Tenet",
                descripcion: "Un agente intenta evitar una catástrofe temporal con la ayuda de la inversión del tiempo.",
                director: "Christopher Nolan",
                categorias: new[] { "Ciencia Ficción", "Acción", "Thriller" },
                anioDeSalida: new DateTime(2020, 8, 26),
                imagenBannerUrl: "https://example.com/tenet-banner.jpg",
                imagenPequeniaUrl: "https://example.com/tenet-small.jpg",
                duracion: "2h 30m",
                valoracion: "7.4"
            ),
            new Pelicula(
                nombre: "Interstellar",
                descripcion: "Un grupo de astronautas busca un nuevo hogar para la humanidad a través de un agujero de gusano.",
                director: "Christopher Nolan",
                categorias: new[] { "Ciencia Ficción", "Drama" },
                anioDeSalida: new DateTime(2014, 11, 7),
                imagenBannerUrl: "https://example.com/interstellar-banner.jpg",
                imagenPequeniaUrl: "https://example.com/interstellar-small.jpg",
                duracion: "2h 49m",
                valoracion: "8.6"
            ),
            new Pelicula(
                nombre: "John Wick",
                descripcion: "Un asesino retirado regresa al mundo del crimen después de que matan a su perro.",
                director: "Chad Stahelski",
                categorias: new[] { "Acción", "Thriller" },
                anioDeSalida: new DateTime(2014, 10, 24),
                imagenBannerUrl: "https://example.com/johnwick-banner.jpg",
                imagenPequeniaUrl: "https://example.com/johnwick-small.jpg",
                duracion: "1h 41m",
                valoracion: "7.4"
            ),
            new Pelicula(
                nombre: "Mad Max: Fury Road",
                descripcion: "Max y Furiosa luchan por la libertad en un mundo postapocalíptico.",
                director: "George Miller",
                categorias: new[] { "Acción", "Aventura", "Ciencia Ficción" },
                anioDeSalida: new DateTime(2015, 5, 15),
                imagenBannerUrl: "https://example.com/madmax-banner.jpg",
                imagenPequeniaUrl: "https://example.com/madmax-small.jpg",
                duracion: "2h",
                valoracion: "8.1"
            ),
            
        });
    }

    private static void InicializarSalas()
    {
       
    }

    private static void InicializarSesiones()
    {
        
    }

    private static void InicializarButacas()
    {
        
    }
}
