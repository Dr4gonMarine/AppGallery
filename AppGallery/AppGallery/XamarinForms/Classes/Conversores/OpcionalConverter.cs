using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AppGallery.XamarinForms.Classes.Conversores
{
    internal class OpcionalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var opcionais = (string)value;
            string opcionaisTexto = opcionais;

            opcionaisTexto = opcionaisTexto
                .Replace("1", "Ar-condionado")
                .Replace("2", "Direção-hidráulica")
                .Replace("3", "Air-Bag");
            return opcionaisTexto;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
