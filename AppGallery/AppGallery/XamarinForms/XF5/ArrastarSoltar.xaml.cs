using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.XF5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArrastarSoltar : ContentPage
    {
        public double Preco = 0.0;
        public int NumeroDeItens= 0;
        public ArrastarSoltar()
        {
            InitializeComponent();
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            e.Data.Properties.Add("Preco", 100.00);
        }

        private void DragGestureRecognizer_DragStarting_1(object sender, DragStartingEventArgs e)
        {
            e.Data.Properties.Add("Preco", 75.00);
        }

        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            double preco = (double)e.Data.Properties["Preco"];
            Preco += preco;
            NumeroDeItens += 1;

            Carrinho.Text = $"Carrinho {NumeroDeItens} Itens - {Preco.ToString("C")}";
        }
    }
}