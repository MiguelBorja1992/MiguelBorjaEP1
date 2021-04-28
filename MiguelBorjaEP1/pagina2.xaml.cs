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
    public partial class pagina2 : ContentPage
    {
        public pagina2(string nombre, double resultado, string user)
        {
            InitializeComponent();
            lblusuario.Text = user;
            lblnombre.Text =  nombre;
            lblPago.Text= Convert.ToString(resultado);
        }
    }
}