namespace MauiApp2.Models
{
    public class Biblioteca
    {
        public List<Libro> Libros { get; set; }
        public List<Usuario> Usuarios { get; set; }

        public Biblioteca()
        {
            Libros = new List<Libro>();
            Usuarios = new List<Usuario>();
        }

        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
        }

        public void AgregarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public string ObtenerCatalogo()
        {
            if (Libros.Count == 0)
            {
                return "No hay libros en el catálogo.";
            }
            return string.Join("\n\n", Libros.Select(l => l.ObtenerInformacion()));
        }
    }
}