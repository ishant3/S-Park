using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using GR.Net.Maroulis.Library;
using Android.Graphics;
using Android.Views;

namespace S_Park_Android
{
    [Activity(Label = "S-Park", MainLauncher = true, Theme = "@style/Theme.AppCompat.Light.NoActionBar",Icon ="@drawable/S_Park_Image")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Show Splash
            var config = new EasySplashScreen(this)
                .WithFullScreen()
                .WithTargetActivity(Java.Lang.Class.FromType(typeof(WelcomeActivity)))
                .WithSplashTimeOut(5000) // 5 sec
                .WithBackgroundColor(Color.ParseColor("#72bcd4"))
                .WithLogo(Resource.Drawable.S_Park_Symbol)
                .WithAfterLogoText("\t \t \t \t \t makes parking \n \t \t the ultimate experiences!!")
                .WithFooterText("© 2018 CIMSOLUTIONS");

            //Set Text Color
            config.AfterLogoTextView.SetTextColor(Color.White);
            config.FooterTextView.SetTextColor(Color.White);
            config.AfterLogoTextView.SetTextSize(Android.Util.ComplexUnitType.Px, 31);


            //Create View
            View view = config.Create();

            //Set Content View
            SetContentView(view);


        }
    }
}

