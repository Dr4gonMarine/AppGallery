using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controle.BarraDeProgressoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraDeProgresso : ContentPage
    {
        Double valorProgressBar = 0.0;

        public BarraDeProgresso()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            valorProgressBar += 0.1;
            Barra.ProgressTo(valorProgressBar, 500, Easing.BounceOut); 
        }
    }
}