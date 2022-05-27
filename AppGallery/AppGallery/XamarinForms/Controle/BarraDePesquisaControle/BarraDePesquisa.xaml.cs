using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controle.BarraDePesquisa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraDePesquisa : ContentPage
    {
        public BarraDePesquisa()
        {
            InitializeComponent();
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            LblSearchButtonPressed.Text = "Botão de pesquisa pressionado";
        }
    }
}