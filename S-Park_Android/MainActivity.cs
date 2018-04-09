using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace S_Park_Android
{
    [Activity(Label = "S-Park", MainLauncher = true, Theme = "@style/Theme.AppCompat.Light.NoActionBar",Icon ="@drawable/S_Park_Image")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

