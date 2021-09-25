using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        int contador;
        string message;
        Button button1;
        public MainPage()
        {
            InitializeComponent();
            contador = 0;
        }

        private void IniciaContador(object sender, EventArgs e)
        {

            var button = ((Button)sender);
            if (button1 == null)
            {
                button1 = ((Button)sender);
            }
            contador++;
            message = "Numero de clicks {0} veces";
            button.Text = String.Format(message, contador);
        }

        private void ReiniciaContador(object sender, EventArgs e)
        {

            contador = 0;

            if (button1 != null)
            {
                button1.Text = message;
            }
        }


    }
}
