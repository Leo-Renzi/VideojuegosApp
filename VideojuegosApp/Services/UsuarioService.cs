using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideojuegosApp.Models;

namespace VideojuegosApp.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario { Id=1, Nombre="Leonardo", Email="leo@example.com", Password="1234", Imagen="images/usuario1.jpg"},
            new Usuario { Id=2, Nombre="Maria", Email="maria@example.com", Password="abcd", Imagen="images/usuario2.jpg"},
            new Usuario { Id=3, Nombre="Carlos", Email="carlos@example.com", Password="qwerty", Imagen="images/usuario3.jpg"}
        };

        public List<Usuario> GetUsuarios() => usuarios;

        public void Add(Usuario u) => usuarios.Add(u);

        public void Delete(int id) => usuarios.RemoveAll(x => x.Id == id);

        public Usuario? GetById(int id) => usuarios.FirstOrDefault(x => x.Id == id);

        public void Update(Usuario usuarioEditado)
        {
            var usuario = usuarios.FirstOrDefault(x => x.Id == usuarioEditado.Id);
            if (usuario != null)
            {
                usuario.Nombre = usuarioEditado.Nombre;
                usuario.Email = usuarioEditado.Email;
                usuario.Password = usuarioEditado.Password;
                usuario.Imagen = usuarioEditado.Imagen;
            }
        }
    }
}
