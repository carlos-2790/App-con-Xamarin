using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bienvenidos : ContentPage
    {
        public Bienvenidos()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                var imc = peso / (altura * altura);
                Imc.Text = imc.ToString();

                string resultado ;

                if (imc < 18.5)
                {
                    resultado = "Tienes bajo peso";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Tu peso es normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Tienes sobre peso ";
                }
                else
                {
                    resultado = "Tienes obesidad";
                }

                DisplayAlert("Resultado", resultado, "OK");
            }
            else
            {
                DisplayAlert("Datos Errones",
                             "Por favor llena toda la información",
                             "OK");
            }
           
           
        }
    }
}