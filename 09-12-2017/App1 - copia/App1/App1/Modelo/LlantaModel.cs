using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App1.Modelo
{
    public class LlantaModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }


        private int ancho;

        public int Ancho
        {
            get { return ancho; }
            set {
                ancho = value;
                OnPropertyChanged();
            }
        }

        private int alto;

        public int Alto
        {
            get { return alto; }
            set {
                alto = value;
                OnPropertyChanged();
            }
        }

        private string datosLlanta;

        public string DatosLlanta
        {
            get {
                return $"{ Ancho.ToString()}{ Alto.ToString()}";
            }
            set {
                datosLlanta = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Mensaje));

            }
        }

        private string mensaje;


        public string Mensaje
        {
            get
            {
                return $"La llanta selecionada es {DatosLlanta}";

            }

        }

        private bool isBusy=false;

        public bool Isbusy
        {
            get { return isBusy=false; }
            set { isBusy = value;
                OnPropertyChanged();
                }


        }


    }






    }

