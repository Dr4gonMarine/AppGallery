using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Leiout.ControleLeiout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardDiretor : ContentView
    {
        public static readonly BindableProperty NomeProperty = BindableProperty.Create("Nome", typeof(String), typeof(CardDiretor));
        public static readonly BindableProperty DescricaoProperty = BindableProperty.Create("Descricao", typeof(String), typeof(CardDiretor));
        public static readonly BindableProperty BoxViewColorProperty = BindableProperty.Create("BoxViewColor", typeof(Color), typeof(CardDiretor));

        public String Nome {
            get { return (String)GetValue(NomeProperty); }
            set { SetValue(NomeProperty, value); }
        }

        public String Descricao { 
            get {return (String)GetValue(DescricaoProperty); }
            set { SetValue (DescricaoProperty, value); }
        }

        public Color BoxViewColor { 
            get { return (Color)GetValue(BoxViewColorProperty); }
            set { SetValue(BoxViewColorProperty, value); }
        }

        public CardDiretor()
        {
            InitializeComponent();
        }
    }
}