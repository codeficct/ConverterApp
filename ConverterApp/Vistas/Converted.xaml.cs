using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConverterApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Converted : ContentPage
    {
        double cm;
        double m;
        public Converted()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            cm = Convert.ToDouble(inputCm.Text);
            m = cm / 100;
            showResult.Text = m.ToString() + " m";
        }

        private void validar()
        {
            if (!string.IsNullOrEmpty(inputCm.Text))
                Calculate();
            else
                throw new ArgumentException("Datos incorrectos o faltantes.");
        }

        private async void navigateToHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void ConvertedCmToM_Clicked(object sender, EventArgs e)
        {
            try
            {
                validar();
            }
            catch (Exception error)
            {
                DisplayAlert("Error", error.Message, "OK");
            }
        }
    }
}