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
        private readonly List<Usuario> usuarios = new()
        {
            new Usuario { Id = 1, NombreUsuario = "admin", Contraseña = "1234", Email = "admin@gmail.com", Imagen="images/avatarhombre.jpg" },
            new Usuario { Id = 2, NombreUsuario = "user",  Contraseña = "abcd", Email = "user@gmail.com",  Imagen="images/avatarmujer.jpg" }
        };

        // Usuario autenticado actualmente
        public Usuario? UsuarioActual { get; private set; }

        // --- ABM básico ---
        public List<Usuario> GetUsuarios() => usuarios;
        public void Add(Usuario u) => usuarios.Add(u);
        public void Delete(int id) => usuarios.RemoveAll(x => x.Id == id);

        // --- Login / Logout ---
        public Usuario? Login(string nombreUsuario, string contraseña)
        {
            var user = usuarios.FirstOrDefault(u =>
                u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña);

            UsuarioActual = user; // queda null si no encontró
            return user;
        }

        public void Logout() => UsuarioActual = null;
    }
}
