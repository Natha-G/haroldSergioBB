namespace MauiApp2.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public List<Libro> LibrosPrestados { get; set; }

        public Usuario(string nombre, int id)
        {
            Nombre = nombre;
            ID = id;
            LibrosPrestados = new List<Libro>();
        }

        public bool PrestarLibro(Libro libro)
        {
            if (libro.Prestar())
            {
                LibrosPrestados.Add(libro);
                return true;
            }
            return false;
        }

        public bool DevolverLibro(Libro libro)
        {
            if (LibrosPrestados.Contains(libro))
            {
                LibrosPrestados.Remove(libro);
                libro.Devolver();
                return true;
            }
            return false;
        }

        public string ObtenerLibrosPrestados()
        {
            if (LibrosPrestados.Count == 0)
            {
                return "No tiene libros prestados.";
            }
            return string.Join("\n\n", LibrosPrestados.Select(l => l.ObtenerInformacion()));
        }
    }
}
