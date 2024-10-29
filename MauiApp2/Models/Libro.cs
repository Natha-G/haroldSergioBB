namespace MauiApp2.Models
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int CantidadDeCopias { get; set; }

        public Libro(string titulo, string autor, string isbn, int cantidadDeCopias)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            CantidadDeCopias = cantidadDeCopias;
        }

        public bool Prestar()
        {
            if (CantidadDeCopias > 0)
            {
                CantidadDeCopias--;
                return true;
            }
            return false;
        }

        public void Devolver()
        {
            CantidadDeCopias++;
        }

        public string ObtenerInformacion()
        {
            return $"Título: {Titulo}\nAutor: {Autor}\nISBN: {ISBN}\nCopias disponibles: {CantidadDeCopias}";
        }
    }
}