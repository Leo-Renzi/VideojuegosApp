namespace VideojuegosApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty; // en prod, hashear!
        public string ImagenUrl { get; set; } = string.Empty;
    }
}
