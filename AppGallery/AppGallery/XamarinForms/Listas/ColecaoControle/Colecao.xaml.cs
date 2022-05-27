using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ColecaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Colecao : ContentPage
    {
        private ObservableCollection<Categoria> categorias { get; set; }
        public Colecao()
        {
            InitializeComponent();

            Colecao01.ItemsSource = GetCategorias();
        }

        private ObservableCollection<Categoria> GetCategorias()
        {
            categorias = new ObservableCollection<Categoria>();

            var sanduiches = new Categoria() {
                new FastFood { Nome = "Subway", QuantidadeDeFranquias = 44870 },
                new FastFood { Nome = "McDonalds", QuantidadeDeFranquias = 37000 },
                new FastFood { Nome = "BurguerKing", QuantidadeDeFranquias = 15000 },
                new FastFood { Nome = "Girafas", QuantidadeDeFranquias = 5000 },
            };
            sanduiches.Nome = "Sanduiches";


            var pizzarias = new Categoria(){

               new FastFood{Nome = "Pizza Hut", QuantidadeDeFranquias = 15000},
               new FastFood { Nome = "Dominos", QuantidadeDeFranquias = 10000 },                
            };
            pizzarias.Nome = "Pizzaria";

            var variedades = new Categoria(){

               new FastFood{Nome = "Starbucks", QuantidadeDeFranquias = 27000},
               new FastFood{Nome = "KFC", QuantidadeDeFranquias = 19000},
               new FastFood{Nome = "Baskin-Robbins", QuantidadeDeFranquias = 7500},
               new FastFood{Nome = "Taco Bell", QuantidadeDeFranquias = 7000},
            };
            variedades.Nome = "Variedades";

            categorias.Add(sanduiches);
            categorias.Add(pizzarias);
            categorias.Add(variedades);

            return categorias;
        }

        public class FastFood
        {
            public string Nome { get; set; }
            public int QuantidadeDeFranquias { get; set; }
        }

        public class Categoria: List<FastFood>
        {
            public string Nome { get; set; }
        }

        private void Colecao01_RemainingItemsThresholdReached(object sender, EventArgs e)
        {
            var restaurantes = new Categoria(){

               new FastFood{Nome = "Marmitex", QuantidadeDeFranquias = 1},
               new FastFood { Nome = "Dauns", QuantidadeDeFranquias = 1000 },
               new FastFood { Nome = "Mix", QuantidadeDeFranquias = 20 },
               new FastFood { Nome = "Tomate Seco", QuantidadeDeFranquias = 200},
               new FastFood { Nome = "Churrascaria SP", QuantidadeDeFranquias = 10 },
               new FastFood { Nome = "Churrascaria Palmeiras", QuantidadeDeFranquias = 10 },
               new FastFood { Nome = "Churrascaria Gaucha", QuantidadeDeFranquias = 1 },
            };
            restaurantes.Nome = "Restaurantes";

            categorias.Add(restaurantes);

            Colecao01.RemainingItemsThreshold = -1;
        }

        private void Colecao01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(FastFood fastfood in Colecao01.SelectedItems)
            {
                sb.Append(fastfood.Nome + " - ");
            }

            LblSelecao.Text = "Seleção : " + sb.ToString();
        }
    }
}