﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Concha.Hamburgue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShellFLyoutItem : Shell
    {
        public AppShellFLyoutItem()
        {
            InitializeComponent();
        }

        private void AbrirAppGallery(object sender, EventArgs e)
        {
            App.Current.MainPage = new AppBase.Menu();
        }
    }
}