using MauiApp2.Models;


namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private async void AgregarLibroButton_Clicked(object sender, EventArgs e)
        {
            string titulo = await DisplayPromptAsync("Agregar Libro", "Ingrese el título:");
            string autor = await DisplayPromptAsync("Agregar Libro", "Ingrese el autor:");
            string isbn = await DisplayPromptAsync("Agregar Libro", "Ingrese el ISBN:");
            string cantidadStr = await DisplayPromptAsync("Agregar Libro", "Ingrese la cantidad de copias:");

            if (int.TryParse(cantidadStr, out int cantidad))
            {
                var libro = new Libro(titulo, autor, isbn, cantidad);
                Biblioteca bb = new();
                bb.AgregarLibro(libro);
                await DisplayAlert("Éxito", $"Libro '{titulo}' agregado a la biblioteca.", "OK");
            }
            else
            {
                await DisplayAlert("Error", "La cantidad debe ser un número válido.", "OK");
            }
        }
    }

}
