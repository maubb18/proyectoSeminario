using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.PAGINAS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagTres : ContentPage
    {
       
        public pagTres()
        {
            InitializeComponent();
        
            
        }
        public void Inicializar()
        {
            btnVelocimetro.Clicked += BtnVelocimetro_Clicked;
        }

        private void BtnVelocimetro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PAGINAS.pagCuatro());

        }
    }
}