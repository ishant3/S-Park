using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace S_Park_Android
{
    [Activity(Label = "WelcomeActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class WelcomeActivity: AppCompatActivity
    {

        private Button mBtnSignUp;
        private ProgressBar mProgressBar;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.Main);

            mBtnSignUp = FindViewById<Button>(Resource.Id.btnSignUp);
            mProgressBar = FindViewById<ProgressBar>(Resource.Id.progressBar1);

            mBtnSignUp.Click += (object sender, EventArgs args) =>
            {
                //Pull up dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                dialog_SignUp signUpDialog = new dialog_SignUp();
                signUpDialog.Show(transaction, "dialog fragment");

                signUpDialog.mOnSignUpComplete += signUpDialog_mOnSignUpComplete;
            };
        }
        void signUpDialog_mOnSignUpComplete(object sender, OnSignUpEventArgs e)
        {

            mProgressBar.Visibility = ViewStates.Visible;
            Thread thread = new Thread(ActLikeARequest);
            thread.Start();


        }

        private void ActLikeARequest()
        {
            Thread.Sleep(3000);

            RunOnUiThread(() => { mProgressBar.Visibility = ViewStates.Invisible; });
            int x = Resource.Animation.slide_right;
        }
    }
}