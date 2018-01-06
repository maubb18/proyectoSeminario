using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagSeleccion : ContentPage
    {
        public pagSeleccion()
        {
           
            InitializeComponent();
            Inicializar();
            int alto1, ancho1;

            #region Datos_Selecccion

            listado1.Items.Add("175"); listado1.Items.Add("180"); listado1.Items.Add("190"); listado1.Items.Add("200");
            listado1.Items.Add("205"); listado1.Items.Add("215"); listado1.Items.Add("220"); listado1.Items.Add("225");

            listado2.Items.Add("30"); listado2.Items.Add("40"); listado2.Items.Add("50"); listado2.Items.Add("55"); listado2.Items.Add("60");

            listado3.Items.Add("175"); listado3.Items.Add("180"); listado3.Items.Add("190"); listado3.Items.Add("200");
            listado3.Items.Add("205"); listado3.Items.Add("215"); listado3.Items.Add("220"); listado3.Items.Add("225");

            listado4.Items.Add("30"); listado4.Items.Add("40"); listado4.Items.Add("50"); listado4.Items.Add("55"); listado4.Items.Add("60");
            listado5.Items.Add("14"); listado5.Items.Add("15"); listado5.Items.Add("16"); listado5.Items.Add("17"); listado5.Items.Add("18"); listado5.Items.Add("19"); listado5.Items.Add("20");
            listado6.Items.Add("14"); listado6.Items.Add("15"); listado6.Items.Add("16"); listado6.Items.Add("17"); listado6.Items.Add("18"); listado6.Items.Add("19"); listado6.Items.Add("20");

            #endregion
        }

        private void Inicializar()
        {
            btnSeguir.Clicked += BtnSeguir_Clicked;
            btnResultado.Clicked += BtnResultado_Clicked;
        }

        private void BtnResultado_Clicked(object sender, EventArgs e)
        {
            if (listado3.SelectedItem != null)
            {
                double al1 = Convert.ToDouble(listado1.SelectedItem.ToString());
                double anch= Convert.ToDouble(listado2.SelectedItem.ToString());
                double al2 = Convert.ToDouble(listado3.SelectedItem.ToString());
                double anch2 = Convert.ToDouble(listado4.SelectedItem.ToString());
                double rin1 = Convert.ToInt16(listado5.SelectedItem.ToString());
                double rin2 = Convert.ToInt16(listado6.SelectedItem.ToString());
                double pulgada = (double)(2.4);
                double aceptable = (double)(2.5);
                rin1 = rin1 * pulgada;
                rin2 = rin2 * pulgada;

                double llanta1 = rin1 + ((al1*anch)/100);
                double llanta2 = rin2 + ((al2 * anch2) / 100);

                double res = llanta1 - llanta2;
                lblResultado.Text = "Diferencia: "+res.ToString()+"%";
                if (res <= aceptable & res >= (aceptable * -1))
                {
                    DisplayAlert("Resultado", "La llanta es correcta!!", "Aceptar");
                }
                else
                {
                    DisplayAlert("Resultado", "La llanta no es compatible!!", "Aceptar");
                }
            }
        }

        private void BtnSeguir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PAGINAS.pagCuatro());
        }

        private void listado1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (e != null)
                listado2.IsEnabled = true;
        }

        private void listado3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (e != null)
                listado4.IsEnabled = true;
        }

        private void listado2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listado5.IsEnabled = true;
        }

        private void listado4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listado6.IsEnabled = true;
        }

        private void listado5_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLlanta1.Text = "Tu llanta actual es: " + listado1.SelectedItem.ToString() + "/" + listado2.SelectedItem.ToString();

            listado2.IsEnabled = false;
            
        }

        private void listado6_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLlanta2.Text = "La llanta a comprar es: " + listado3.SelectedItem.ToString() + "/" + listado4.SelectedItem.ToString();

        }
    }
}