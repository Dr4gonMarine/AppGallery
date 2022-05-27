using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.CurrentActivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(AppGallery.Droid.Effect.StatusBarEffect), "StatusBarEffect")]

namespace AppGallery.Droid.Effect
{
    public class StatusBarEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var statusBarEffect = (AppGallery.Recursos.Effects.StatusBarEffect)Element.Effects.FirstOrDefault(e => e is AppGallery.Recursos.Effects.StatusBarEffect);

            if (statusBarEffect != null)
            {
                var BackgroundColor = statusBarEffect.BackgroundColor.ToAndroid();
                Window currentWindow = GetCurrentWindow();
                currentWindow.SetStatusBarColor(BackgroundColor);
            }
        }

        protected override void OnDetached()
        {

        }

        Window GetCurrentWindow()
        {
            var window = CrossCurrentActivity.Current.Activity.Window;

            window.ClearFlags(WindowManagerFlags.TranslucentStatus);
            window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);

            return window;
        }
    }
}