using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MiguelBorjaEP1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = TxtUsuario.Text;
                string pass = TxtPass.Text;
                if (usuario == "estudiante2021")
                {
                    if (pass == "uisrael2021")
                    {
                        await Navigation.PushAsync(new pagina1(usuario));
                    }
                }
                else
                {
                    DisplayAlert("Alerta", "Error de contraseña", "Gracias");
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }
        }
    }
}
