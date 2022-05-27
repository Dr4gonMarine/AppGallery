using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Classes.Alertas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alerta : ContentPage
    {
        public Alerta()
        {
            InitializeComponent();
        }

        private void BtnDisplayAlert(object sender, EventArgs e)
        {
            DisplayAlert("Este é meu DisplayAlert", "Clique no OK para fechar", "OK");
        }

        private void BtnDisplayActionSheet(object sender, EventArgs e)
        {
            DisplayActionSheet("Escolha sua marca predileta: ", "OK", null, "Nintendo", "Sony", "Xbox");
        }

        private async void BtnDisplayPrompt(object sender, EventArgs e)
        {
            string nome = await DisplayPromptAsync("Entrada de dados", "Digite seu nome");
        }
    }
}