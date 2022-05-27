using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ClassesEspecias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificarMudançaPropriedade : ContentPage
    {
        public NotificarMudançaPropriedade()
        {
            InitializeComponent();

            Lista01.ItemsSource = new List<Carro>
            {
                new Carro() {Nome = "FIAT Uno", Motor = "1.0"}
            };
        }
        public class Carro : INotifyPropertyChanged
        {
            private string _nome;
            private string _motor;

            public string Nome
            {
                get
                {
                    return _nome;
                }
                set
                {
                    _nome = value;
                    RaisePropertyChanged("Nome");
                }
            }
            public string Motor
            {
                get
                {
                    return _motor;
                }
                set
                {
                    _motor = value;
                    RaisePropertyChanged(nameof(Motor));
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            private void RaisePropertyChanged(string prop)
            {
                if(PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string nome = Nome.Text;
            string motor = Motor.Text;

            var lista = (List<Carro>)Lista01.ItemsSource;

            lista[0].Nome = nome;
            lista[0].Motor = motor;
        }
    }
}