using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controle.CampoDeEntradaMultiLineControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampoDeEntradaMultiLine : ContentPage
    {
        public CampoDeEntradaMultiLine()
        {
            InitializeComponent();
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            Lblfocus.Text = "Campo focado!";
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            Lblunfocus.Text = "Foco removido do campo!";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Lbltextchage.Text = e.NewTextValue + "-" + e.NewTextValue.Length;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            Lblcomplete.Text = "Preenchimento finalizado!";
        }
    }
}