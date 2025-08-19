using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideojuegosApp.Models;

namespace VideojuegosApp.Services
{
    public class VideojuegoService
    {
        private List<Videojuego> videojuegos = new List<Videojuego>
        {
            new Videojuego { Id=1, Titulo="The Legend of Zelda", Genero="Aventura", Consola="Switch", Precio=59.99m, Imagen="images/zelda.jpg"},
            new Videojuego { Id=2, Titulo="God of War", Genero="Acción", Consola="PS5", Precio=69.99m, Imagen="images/gow.jpg"},
            new Videojuego { Id=3, Titulo="Halo Infinite", Genero="Shooter", Consola="Xbox", Precio=49.99m, Imagen="images/halo.jpg"}
        };

        public List<Videojuego> GetVideojuegos() => videojuegos;

        public void Add(Videojuego v) => videojuegos.Add(v);

        public void Delete(int id) => videojuegos.RemoveAll(x => x.Id == id);
    }
}
