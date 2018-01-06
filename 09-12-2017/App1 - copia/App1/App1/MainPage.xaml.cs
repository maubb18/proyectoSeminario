using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            Inicializar();
            imagen1.Source = ImageSource.FromFile("llanta.jpg");
            var image = new Image { Source = "llan.png" };
        }

        private void Inicializar()
        {
            btnIngresar.Clicked += BtnIngresar_Clicked;
            var image = new Image { Source = "llan.png" };
            
        }

        private void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new pagSeleccion());
        }
    }
}
