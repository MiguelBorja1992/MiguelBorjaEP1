using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiguelBorjaEP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagina1 : ContentPage
    {
        public pagina1(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = usuario;


        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                double inicial = Convert.ToDouble(txtMonto.Text);
                double mensual = Convert.ToDouble(txtPago.Text);

                double cal1= 1800 + 1800 * 0.05;
                double saldo = cal1 - inicial;
                double resultado = (saldo/ mensual)+90;
                txttotal.Text = resultado.ToString();
                //await Navigation.PushAsync(new pagina2(nombre));
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string user = lblusuario.Text;
            string nombre = txtNombre.Text;
            double inicial = Convert.ToDouble(txtMonto.Text);
            double mensual = Convert.ToDouble(txtPago.Text);

            double cal1 = 1800 + 1800 * 0.05;
            double saldo = cal1 - inicial;
            double resultado = (saldo / mensual) + 90;
            DisplayAlert("Alerta","Elemento guardado con exito", "Gracias");
            await Navigation.PushAsync(new pagina2(nombre,resultado,user));
        }
    }
}