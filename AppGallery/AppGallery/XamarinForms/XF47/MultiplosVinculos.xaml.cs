using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.XF47
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiplosVinculos : ContentPage
    {
        public MultiplosVinculos()
        {
            InitializeComponent();
            BindingContext = new Pessoa()
            {
                Nome = "Elias",
                Hj = DateTime.Now.Date
            };
        }
        public class Pessoa
        {
            public string Nome { get; set; }
            public DateTime Hj { get; set; }
        }
    }   
}