using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TrainningCode.Droid
{
    [Activity(Label = "TrainningCode", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            //ZXing.Net.Mobile.Forms.iOS.Platform.Init();
            InitControl(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //XF.Material.Droid.Material.Init(this, savedInstanceState);


            LoadApplication(new App());
        }

        private void InitControl(Bundle savedInstanceState)
        {
            global::Xamarin.Forms.Forms.SetFlags("FastRenderers_Experimental");
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::ZXing.Net.Mobile.Forms.Android.Platform.Init();
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(true);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}