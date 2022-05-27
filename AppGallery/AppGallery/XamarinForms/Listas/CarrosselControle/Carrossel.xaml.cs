using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.CarrosselControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrossel : ContentPage
    {
        private ObservableCollection<Colaborador> colaboradores { get; set; }
        public Carrossel()
        {
            InitializeComponent();
            colaboradores = GetColaboradores();
            Carrossel01.ItemsSource = colaboradores;
        }

        private ObservableCollection<Colaborador> GetColaboradores()
            {
            return new ObservableCollection<Colaborador>()
                {
                    new Colaborador(){Nome = "João Ribeiro", Cargo = "Web Designer", Descricao="Sou Web Disigner desde 2010. Conheço CSS, HTML, Adobe Photoshop, Adobe Ilustrator e Autodesck 3D MAX"},
                    new Colaborador(){Nome ="Felipe Rodrigues", Cargo ="Programador", Descricao="Sou Programador Java desde 2010. Trabalhei com JSF, JSP, Java EE, HTM, CSS"},
                    new Colaborador(){Nome ="Lucas Paulo", Cargo ="Programador Web", Descricao="Sou Programador desde 2010."},
                    new Colaborador(){Nome ="Maria Ribeiro", Cargo ="Programador PHP", Descricao="Sou Programador desde 2010. Trabalho desde 2000 com PHP"},
                };
            }

        public class Colaborador
        {
            public string Nome { get; set; }
            public string Cargo { get; set; }
            public string Descricao { get; set; }
        }

    

        private void Carrossel01_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            try
            {
                var colaborador = (Colaborador)e.CurrentItem;
                LblItem.Text = "Nome " + colaborador.Nome;
            }
            catch (Exception ex)
            {

                    App.Current.MainPage.DisplayAlert("Alerta!", ex.Message, "OK");

            }
        }

        private void Carrossel01_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            LblPosition.Text = "Posição: " + e.CurrentPosition + " - Posição Anterior: " + e.PreviousPosition;
        }

        private void Carrossel01_RemainingItemsThresholdReached(object sender, EventArgs e)
        {
            colaboradores.Add(new Colaborador() { Nome = "Emanoel Rodrigues", Cargo = "Web Designer", Descricao = "Sou Web Disigner desde 2010. Conheço CSS, HTML, Adobe Photoshop, Adobe Ilustrator e Autodesck 3D MAX" });
            colaboradores.Add(new Colaborador() { Nome = "Madalena Rodrigues", Cargo = "Web Designer", Descricao = "Sou Web Disigner desde 2010. Conheço CSS, HTML, Adobe Photoshop, Adobe Ilustrator e Autodesck 3D MAX" });
            colaboradores.Add(new Colaborador() { Nome = "Jessica Silva", Cargo = "Web Designer", Descricao = "Sou Web Disigner desde 2010. Conheço CSS, HTML, Adobe Photoshop, Adobe Ilustrator e Autodesck 3D MAX" });

            Carrossel01.RemainingItemsThreshold = -1;
        }
    }
}