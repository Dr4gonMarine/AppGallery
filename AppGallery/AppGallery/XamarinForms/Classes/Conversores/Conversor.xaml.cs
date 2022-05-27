using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Classes.Conversores
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conversor : ContentPage
    {
        public Conversor()
        {
            InitializeComponent();

            Lista01.ItemsSource = new List<Veiculo>
            {
                new Veiculo{ Marca = "FIAT", Modelo="UNO", Opcionais="1,2,3", Valor = 38000},
                new Veiculo{ Marca = "CHEVROLET", Modelo="Onix", Opcionais="2,3", Valor = 50000},
                new Veiculo{ Marca = "AUDI", Modelo="Aquele la", Opcionais="1", Valor = 200000},
                new Veiculo{ Marca = "FIAT", Modelo="Ka", Opcionais="3", Valor = 68000},
            };
        }
    }

    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Opcionais { get; set; }
        public double Valor { get; set; }
    }
}