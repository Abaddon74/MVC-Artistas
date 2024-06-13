using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Artistas.Models;
using System.Collections.Generic;

namespace Artistas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hobbies()
        {
            var hobbies = new List<string> { "Leer", "Programar", "Tocar la guitarra" };
            return View(hobbies);
        }

        public IActionResult Artists()
        {
            var artists = new List<Artist>
            {
                new Artist
                {
                    Name = "Artist 1",
                    ImageUrl = "https://via.placeholder.com/150",
                    Summary = "Resumen del artista 1",
                    Works = new List<string> { "Obra 1", "Obra 2", "Obra 3", "Obra 4", "Obra 5" },
                    Link = "https://es.wikipedia.org/wiki/Artist_1"
                },
                new Artist
                {
                    Name = "Artist 2",
                    ImageUrl = "https://via.placeholder.com/150",
                    Summary = "Resumen del artista 2",
                    Works = new List<string> { "Obra 1", "Obra 2", "Obra 3", "Obra 4", "Obra 5" },
                    Link = "https://es.wikipedia.org/wiki/Artist_2"
                },
                new Artist
                {
                    Name = "Artist 3",
                    ImageUrl = "https://via.placeholder.com/150",
                    Summary = "Resumen del artista 3",
                    Works = new List<string> { "Obra 1", "Obra 2", "Obra 3", "Obra 4", "Obra 5" },
                    Link = "https://es.wikipedia.org/wiki/Artist_3"
                }
            };

            return View(artists);
        }
    }
}

