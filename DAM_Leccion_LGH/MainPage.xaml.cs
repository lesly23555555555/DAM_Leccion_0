using DAM_Leccion_LGH.Model;

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
            personaModel.Nombre = "Hola aqui estoy";
            txtNombre.Text = "hola aqui estoy";
        }
        private void Aceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sitema", "Se ha guardado el registro en la BD", "Aceptar");
        }
    }

}
