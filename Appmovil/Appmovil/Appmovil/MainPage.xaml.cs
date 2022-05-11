using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Appmovil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var primero = int.Parse(Primero.Text);
            var segundo = int.Parse(Segundo.Text);

            var resultado = primero + segundo;
            Sresultado.Text = resultado.ToString();

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var primero = int.Parse(Primero.Text);
            var segundo = int.Parse(Segundo.Text);

            var resultado = primero - segundo;
            Rresultado.Text = resultado.ToString();
        }


        public void Button_Clicked_2(object sender, EventArgs args)
        {
            var button = new Button()
            {
                Text = "Hello, Forms !",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Red,
                BorderColor = Color.Blue,
            };

        }
    }
}
