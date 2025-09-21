using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideojuegosApp.Models
{
    public class Videojuego
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public string Genero { get; set; } = "";
        public string Consola { get; set; } = "";
        public decimal Precio { get; set; }
        public string Imagen { get; set; } = ""; // Ruta de imagen local...
    }
}
