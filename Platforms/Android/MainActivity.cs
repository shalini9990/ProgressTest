using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using ProgressTest;
using ProgressTest.Views;

namespace ProgressTest
{
    [Activity(Label = "ProgressTest", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public int TabLayoutResource { get; private set; }
        public object ImageCircleRenderer { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState, int ToolbarResource)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Init(this, savedInstanceState);
            object value1 = ImageCircleRenderer.Init();
            object value = LoadApplication(new App());
        }

        private object LoadApplication(App app)
        {
            throw new NotImplementedException();
        }
    }
}