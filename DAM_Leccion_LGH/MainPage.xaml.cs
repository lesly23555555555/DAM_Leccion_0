using DAM_Leccion_LGH.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAM_Leccion_LGH
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        public void Ejecutar()
        {
            PersonaModel personaModel = new PersonaModel();
            {
                Nombre = "Hola aqui estoy",

            };
            BindingContext = personaModel.Nombre;

            //txtNombre.Text = "hola aqui estoy";

            //Binding personaBinding = new Binding();
            //personaBinding.Source = personaModel; // origen 
            //personaBinding.Path = "Nombre"; // Ruta
            //txtNombre.SetBinding(Entry.TextProperty, personaBinding); // destino final
        }

        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sitema", "Se ha guardado el registro en la BD", "Aceptar");
        }
    }

}
