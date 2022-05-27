using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controle.ArrastoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Arrasto : ContentPage
    {
        public Arrasto()
        {
            InitializeComponent();
        }

        private void SwipeDetalhe(object sender, EventArgs e)
        {
            LblDetalhe.Text = $"Acionado Detalhe: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void SwipeEditar(object sender, EventArgs e)
        {
            LblEditar.Text = $"Acionado Editar: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void SwipeExcluir(object sender, EventArgs e)
        {
            LblExcluir.Text = $"Acionado Excluir: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void SwipeView_SwipeChanging(object sender, SwipeChangingEventArgs e)
        {
            LblChanging.Text = $"Acionado Changing: {DateTime.Now.ToString("HH:mm:ss ")}"+e.SwipeDirection+" - " + e.Offset;
        }

        private void SwipeView_SwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            LblEnded.Text = $"Acionado Ended: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void SwipeView_SwipeStarted(object sender, SwipeStartedEventArgs e)
        {
            LblStarted.Text = $"Acionado Started: {DateTime.Now.ToString("HH:mm:ss ")}"+e.SwipeDirection;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SwipeViewControle.Close();
            LblBotaoCLose.Text = "Fechar Acionado";
        }
    }
}