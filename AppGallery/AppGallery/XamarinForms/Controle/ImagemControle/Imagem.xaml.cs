using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controle.ImagemControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Imagem : ContentPage
    {
        public Imagem()
        {
            InitializeComponent();

            //resourceID = "AppGallery.XamarinForms.Controle.ImagemControle.background.png
            //Image01.Source = ImageSource.FromResource("AppGallery.XamarinForms.Controle.ImagemControle.background.png")
        }
    }
}