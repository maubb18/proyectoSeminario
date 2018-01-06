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
    public partial class pagDos : ContentPage
    {
        public object Picker_SelectedItem { get; private set; }

        public pagDos()
        {
            InitializeComponent();
            Inicializar();
            listado.Items.Add("14");
            listado.Items.Add("15");
            listado.Items.Add("16");
            listado.Items.Add("17");
            listado.Items.Add("18");

            listado2.Items.Add("225-40");
            listado2.Items.Add("230-50");
        }

        private void Inicializar()
        {
            btnResultados.Clicked += BtnResultados_Clicked;
            
            //lblTexto.Text = listado2.SelectedItem.ToString();
            
        }

        private void BtnResultados_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PAGINAS.pagTres());
        }

    }
}