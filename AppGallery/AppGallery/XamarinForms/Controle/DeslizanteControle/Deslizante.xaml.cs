using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controle.DeslizanteControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Deslizante : ContentPage
    {
        public Deslizante()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            LblValueChanged.Text = "Valor antigo: " + e.OldValue.ToString() + "Valor novo: " + e.NewValue.ToString();
        }

        private void Slider_DragStarted(object sender, EventArgs e)
        {
            LblDragStarted.Text = "Iniciou o arrasto!";
        }

        private void Slider_DragCompleted(object sender, EventArgs e)
        {
            LblDragCompleted.Text = "Parou o arrastar!";
        }

        private void Slider_ValueChanged_1_Step(object sender, ValueChangedEventArgs e)
        {
            int passos = 2;
            int novoPasso = (int)Math.Round(e.NewValue /passos);
            ((Slider)sender).Value = novoPasso * passos;
            LblIncremento.Text = ((Slider)sender).Value.ToString();
        }
    }
}