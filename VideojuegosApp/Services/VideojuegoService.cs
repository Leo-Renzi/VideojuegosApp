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
            new Videojuego { Id=1, Titulo="GTA San Andreas", Genero="Accion-RPG", Consola="PS4", Precio=59.99m, Imagen="images/GTA.SanAndreas.jpg"},
            new Videojuego { Id=2, Titulo="God of War 2", Genero="Acción", Consola="PS2", Precio=69.99m, Imagen="images/GodOfWar2.jpg"},
            new Videojuego { Id=3, Titulo="Dragon Ball Z Budokai Tenkaichi 3", Genero="Lucha", Consola="PS2", Precio=49.99m, Imagen="images/DBZ_3.jpg"},
            new Videojuego { Id=4, Titulo="Bully", Genero="Accion-RPG", Consola="PS2", Precio=59.99m, Imagen="images/Bully.jpg"},
            new Videojuego { Id=5, Titulo="Final Fantasy", Genero="Aventura-RPG", Consola="PS2", Precio=69.99m, Imagen="images/FinalFantasy.png"},
            new Videojuego { Id=6, Titulo="Need for Speed Most Wanted", Genero="Carreras", Consola="PC", Precio=49.99m, Imagen="images/NFS_MostWanted.jpg"},
            new Videojuego { Id=7, Titulo="Ratchet y Clank", Genero="Aventura", Consola="PS4", Precio=59.99m, Imagen="images/Ratchet.y.clank.png"},
            new Videojuego { Id=8, Titulo="Prince of Persia", Genero="Aventura", Consola="Xbox", Precio=69.99m, Imagen="images/PrinceOfPersia.png"},
            new Videojuego { Id=9, Titulo="Borderlands", Genero="Lucha", Consola="Xbox 360", Precio=49.99m, Imagen="images/Borderlands.jpg"},
            new Videojuego { Id=10, Titulo="Luigi's Mansion", Genero="Aventura", Consola="GameCube", Precio=49.99m, Imagen="images/LuigisMansion.jpg"}
        };

        public List<Videojuego> GetVideojuegos() => videojuegos;

        public void Add(Videojuego v) => videojuegos.Add(v);

        public void Delete(int id) => videojuegos.RemoveAll(x => x.Id == id);
    }
}
