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
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 160,
                valoracion: 8.50
            ),
            new Pelicula(
                nombre: "Cómo entrenar a tu dragón 3",
                descripcion: "Hipo y Desdentao enfrentan nuevos desafíos mientras buscan un mundo escondido para los dragones.",
                director: "Dean DeBlois",
                categorias: new[] { "Animación", "Fantasía", "Aventura" },
                anioDeSalida: new DateTime(2019, 2, 22),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 105,
                valoracion: 9.00
            ),
            new Pelicula(
                nombre: "Halloween (2018)",
                descripcion: "Laurie Strode se enfrenta nuevamente a Michael Myers en este reinicio de la franquicia.",
                director: "David Gordon Green",
                categorias: new[] { "Terror", "Suspenso" },
                anioDeSalida: new DateTime(2018, 10, 19),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 105,
                valoracion: 7.00
            ),
            new Pelicula(
                nombre: "Halloween Kills",
                descripcion: "Michael Myers continúa su masacre mientras Haddonfield decide luchar contra él.",
                director: "David Gordon Green",
                categorias: new[] { "Terror", "Suspenso" },
                anioDeSalida: new DateTime(2021, 10, 15),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 105,
                valoracion: 6.50
            ),
            new Pelicula(
                nombre: "Halloween Ends",
                descripcion: "Laurie Strode se enfrenta a Michael Myers por última vez en un enfrentamiento épico.",
                director: "David Gordon Green",
                categorias: new[] { "Terror", "Suspenso" },
                anioDeSalida: new DateTime(2022, 10, 14),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 110,
                valoracion: 6.00
            ),
            new Pelicula(
                nombre: "Tenet",
                descripcion: "Un agente intenta evitar una catástrofe temporal con la ayuda de la inversión del tiempo.",
                director: "Christopher Nolan",
                categorias: new[] { "Ciencia Ficción", "Acción", "Thriller" },
                anioDeSalida: new DateTime(2020, 8, 26),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 150,
                valoracion: 7.40
            ),
            new Pelicula(
                nombre: "Interstellar",
                descripcion: "Un grupo de astronautas busca un nuevo hogar para la humanidad a través de un agujero de gusano.",
                director: "Christopher Nolan",
                categorias: new[] { "Ciencia Ficción", "Drama" },
                anioDeSalida: new DateTime(2014, 11, 7),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 169,
                valoracion: 8.60
            ),
            new Pelicula(
                nombre: "John Wick",
                descripcion: "Un asesino retirado regresa al mundo del crimen después de que matan a su perro.",
                director: "Chad Stahelski",
                categorias: new[] { "Acción", "Thriller" },
                anioDeSalida: new DateTime(2014, 10, 24),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 101,
                valoracion: 7.40
            ),
            new Pelicula(
                nombre: "Mad Max: Fury Road",
                descripcion: "Max y Furiosa luchan por la libertad en un mundo postapocalíptico.",
                director: "George Miller",
                categorias: new[] { "Acción", "Aventura", "Ciencia Ficción" },
                anioDeSalida: new DateTime(2015, 5, 15),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 120,
                valoracion: 8.10
            ),
            new Pelicula(
                nombre: "Black Panther",
                descripcion: "T'Challa, rey de Wakanda, debe defender su trono y a su nación de un enemigo poderoso.",
                director: "Ryan Coogler",
                categorias: new[] { "Acción", "Aventura", "Superhéroes" },
                anioDeSalida: new DateTime(2018, 2, 16),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 134,
                valoracion: 7.30
            ),

            new Pelicula(
                nombre: "El Renacido",
                descripcion: "Hugh Glass lucha por sobrevivir en el desierto tras ser atacado por un oso y traicionado por su equipo.",
                director: "Alejandro G. Iñárritu",
                categorias: new[] { "Drama", "Aventura" },
                anioDeSalida: new DateTime(2015, 12, 25),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 156,
                valoracion: 8.00
            ),

            new Pelicula(
                nombre: "La La Land",
                descripcion: "Una historia de amor entre un músico de jazz y una actriz aspirante en Los Ángeles.",
                director: "Damien Chazelle",
                categorias: new[] { "Drama", "Musical", "Romance" },
                anioDeSalida: new DateTime(2016, 12, 9),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 128,
                valoracion: 8.00
            ),

            new Pelicula(
                nombre: "The Batman",
                descripcion: "Bruce Wayne investiga una serie de asesinatos conectados a la corrupción en Gotham.",
                director: "Matt Reeves",
                categorias: new[] { "Acción", "Crimen", "Thriller" },
                anioDeSalida: new DateTime(2022, 3, 4),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 176,
                valoracion: 8.20
            ),

            new Pelicula(
                nombre: "A Quiet Place",
                descripcion: "Una familia vive en silencio para evitar a criaturas que cazan por el sonido.",
                director: "John Krasinski",
                categorias: new[] { "Terror", "Drama", "Suspenso" },
                anioDeSalida: new DateTime(2018, 4, 6),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 90,
                valoracion: 7.50
            ),

            new Pelicula(
                nombre: "Get Out",
                descripcion: "Un joven descubre un oscuro secreto durante una visita a la familia de su novia.",
                director: "Jordan Peele",
                categorias: new[] { "Terror", "Thriller", "Misterio" },
                anioDeSalida: new DateTime(2017, 2, 24),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 104,
                valoracion: 8.00
            ),

            new Pelicula(
                nombre: "Knives Out",
                descripcion: "Un detective investiga la muerte de un novelista famoso en su excéntrica familia.",
                director: "Rian Johnson",
                categorias: new[] { "Crimen", "Drama", "Comedia" },
                anioDeSalida: new DateTime(2019, 11, 27),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 130,
                valoracion: 7.90
            ),

            new Pelicula(
                nombre: "1917",
                descripcion: "Dos soldados británicos reciben una misión para entregar un mensaje vital durante la Primera Guerra Mundial.",
                director: "Sam Mendes",
                categorias: new[] { "Drama", "Guerra", "Historia" },
                anioDeSalida: new DateTime(2019, 12, 25),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 119,
                valoracion: 8.30
            ),

            new Pelicula(
                nombre: "El Hombre Invisible",
                descripcion: "Una mujer cree que su abusivo exnovio se ha vuelto invisible para atormentarla.",
                director: "Leigh Whannell",
                categorias: new[] { "Terror", "Ciencia Ficción", "Suspenso" },
                anioDeSalida: new DateTime(2020, 2, 28),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 124,
                valoracion: 7.10
            ),

            new Pelicula(
                nombre: "Soul",
                descripcion: "Un músico de jazz busca encontrar el propósito de su vida después de un accidente inesperado.",
                director: "Pete Docter, Kemp Powers",
                categorias: new[] { "Animación", "Fantasía", "Aventura" },
                anioDeSalida: new DateTime(2020, 12, 25),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 100,
                valoracion: 8.10
            ),

            new Pelicula(
                nombre: "Parasite",
                descripcion: "Una familia pobre se infiltra en la vida de una familia rica con consecuencias inesperadas.",
                director: "Bong Joon-ho",
                categorias: new[] { "Drama", "Comedia Negra", "Thriller" },
                anioDeSalida: new DateTime(2019, 5, 30),
                imagenBannerUrl: "",
                imagenPequeniaUrl: "",
                duracion: 132,
                valoracion: 8.60
            ),
        });
    }
    
    private static void InicializarSalas()
    {
       
    }

    private static void InicializarButacas()
    {
        
    }

    private static void InicializarSesiones()
    {
        
    }

   
}
