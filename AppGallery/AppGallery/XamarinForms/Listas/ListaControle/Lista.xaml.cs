using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ListaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();

            Lista01.ItemsSource = GetMarcas();
        }

        private List<Marca> GetMarcas()
        {
            return new List<Marca>()
            {
                GetListaCarrosFIAT(),
                GetListaCarrosFORD()
            };
        }

        private Marca GetListaCarrosFIAT()
        {

            var FIAT = new Marca()
            {
                new Carro {Nome = "Mobi",
                    Motorizacao = "1.0",
                    Descricao = "AVENTURA NAO VAI FALTAR",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                 new Carro {Nome = "Uno",
                    Motorizacao = "1.0",
                    Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris rhoncus pharetra tortor, nec feugiat dui consequat vitae. Vestibulum eu auctor.",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                  new Carro {Nome = "Argo",
                    Motorizacao = "1.0 - 1.6",
                    Descricao = "AVENTURA NAO VAI FALTAR",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                   new Carro {Nome = "Cronos",
                    Motorizacao = "1.0",
                    Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris rhoncus pharetra tortor, nec feugiat dui consequat vitae. Vestibulum eu auctor.",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                    new Carro {Nome = " Toro",
                    Motorizacao = "1.8",
                    Descricao = "AVENTURA NAO VAI FALTAR",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                    new Carro {Nome = " Grand Sieda",
                    Motorizacao = "1.0",
                    Descricao = "AVENTURA NAO VAI FALTAR",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                    new Carro {Nome = " Sieda",
                    Motorizacao = "1.6",
                    Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut felis elit. Mauris vitae tincidunt tortor. Etiam lacinia pellentesque diam, eget laoreet justo efficitur a. Ut in elementum odio, eu.",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                    new Carro {Nome = " Dublò",
                    Motorizacao = "1.8",
                    Descricao = "AVENTURA NAO VAI FALTAR",
                 ItemsDeSerie = "Air bag, direção eletrica"},

            };

            FIAT.Nome = "FIAT";

            return FIAT;
        }

        private Marca GetListaCarrosFORD()
        {

            var FORD = new Marca()
            {
                new Carro {Nome = "Ka",
                    Motorizacao = "1.0 - 1.2",
                    Descricao = "AVENTURA NAO VAI FALTAR",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                 new Carro {Nome = "Ka Sedan",
                    Motorizacao = "2.0",
                    Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris rhoncus pharetra tortor, nec feugiat dui consequat vitae. Vestibulum eu auctor.",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                  new Carro {Nome = "Fusion",
                    Motorizacao = "1.0 - 1.6",
                    Descricao = "AVENTURA NAO VAI FALTAR",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                   new Carro {Nome = "Ecosport",
                    Motorizacao = "1.8",
                    Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris rhoncus pharetra tortor, nec feugiat dui consequat vitae. Vestibulum eu auctor.",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                    new Carro {Nome = " Novo Edge",
                    Motorizacao = "2.4 - 3.0 TURBO",
                    Descricao = "AVENTURA NAO VAI FALTAR",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                    new Carro {Nome = "Ranger Mustang",
                    Motorizacao = "10.0",
                    Descricao = "AVENTURA NAO VAI FALTAR",
                 ItemsDeSerie = "Air bag, direção eletrica"},
            };

            FORD.Nome = "FORD";

            return FORD;
        }

        private Marca GetListaCarrosRENAULT()
        {

            var RENAULT = new Marca()
            {
                new Carro {Nome = "Kwid",
                    Motorizacao = "1.0 - 1.2",
                    Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris rhoncus pharetra tortor, nec feugiat dui consequat vitae. Vestibulum eu auctor.",
                 ItemsDeSerie = "Air bag, direção eletrica"},

                new Carro {Nome = "Sandero",
                    Motorizacao = "1.0 - 1.2",
                    Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris rhoncus pharetra tortor, nec feugiat dui consequat vitae. Vestibulum eu auctor.",
                 ItemsDeSerie = "Air bag, direção eletrica"},

            };

            RENAULT.Nome = "FORD";

            return RENAULT;
        }

        public class Carro
        {
            public string Nome { get; set; }
            public string Motorizacao { get; set; }
            public string Descricao { get; set; }
            public string ItemsDeSerie { get; set; }
        }

        public class Marca : List<Carro>
        {
            public string Nome { get; set; }
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var parametro = ((MenuItem)sender).CommandParameter;
            var carro = (Carro)parametro;
            DisplayAlert("Clicou no Visualizar", $"Registro: {carro.Nome}", "Ok");
        }

        private void Lista01_Refreshing(object sender, EventArgs e)
        {
            var marcas = new List<Marca>()
            {
                GetListaCarrosRENAULT()
           }; 
            Lista01.ItemsSource = marcas;
            Lista01.IsRefreshing = false;
        }

        private void Lista01_Scrolled(object sender, ScrolledEventArgs e)
        {
            LblScroll.Text = "Y: " + e.ScrollY.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var marcas = (List<Marca>)Lista01.ItemsSource;
            var FORD = marcas[1];
            var KA = FORD[0];

            Lista01.ScrollTo(KA, ScrollToPosition.Center, true);
        }
    }
}