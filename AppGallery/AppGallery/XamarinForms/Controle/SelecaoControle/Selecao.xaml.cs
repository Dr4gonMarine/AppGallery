using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controle.SelecaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Selecao : ContentPage
    {
        public Selecao()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblInformativo.Text = ((Picker)sender).SelectedIndex + " - " + ((Picker)sender).SelectedItem;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PickerMarca.SelectedIndex = -1;
        }
    }
}