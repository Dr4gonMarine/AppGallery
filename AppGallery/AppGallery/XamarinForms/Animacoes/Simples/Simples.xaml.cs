using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Animacoes.Simples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Simples : ContentPage
    {
        public Simples()
        {
            InitializeComponent();
        }

        private async void BtnTranslate(object sender, EventArgs e)
        {
            await Box.TranslateTo(100, 50, 500, Easing.Linear);
            await Task.Delay(1000);
            await Box.TranslateTo(0, 0, 1000, Easing.BounceOut);
        }

        private async void BtnRotate(object sender, EventArgs e)
        {
            await Box.RotateTo(90, 500, Easing.SpringOut);
            await Task.Delay(1000);
            await Box.RotateTo(0, 1000, Easing.CubicOut);
        }

        private async void BtnScale(object sender, EventArgs e)
        {
            await Box.ScaleTo(2, 500, Easing.CubicIn);
            await Task.Delay(1000);
            await Box.ScaleTo(1, 1000, Easing.Linear);
        }

        private async void BtnOpacity(object sender, EventArgs e)
        {
            await Box.FadeTo(.3, 500, Easing.Linear);
            await Task.Delay(1000);
            await Box.FadeTo(1, 1000, Easing.BounceIn);
        }

        private async void BtnAnimacaoCombinada(object sender, EventArgs e)
        {
             await Task.WhenAll(Box.TranslateTo(0, 150, 2000, Easing.SpringOut),
             Box.ScaleTo(1.5, 2000, Easing.BounceOut),
             Box.RotateTo(45, 2000, Easing.SpringOut));
             
            await Task.Delay(1000);

            await Task.WhenAll(Box.TranslateTo(0, 0, 1000, Easing.SpringOut),
             Box.ScaleTo(1, 1000, Easing.BounceOut),
             Box.RotateTo(0, 1000, Easing.SpringOut));
        }

        private async void BtnAnimacaoPersonalizada(object sender, EventArgs e)
        {
            var animacao = new Animation(v => Box.CornerRadius = v, 5 , 30);
            animacao.Commit(Box, "CornerAnimation", 300, 1000, Easing.Linear, null);
            

            await Task.Delay(3000);           
        }
    }
}