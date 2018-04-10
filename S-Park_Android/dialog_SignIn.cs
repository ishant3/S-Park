using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace S_Park_Android
{

    public class OnSignInEventArgs : EventArgs
    {
        private string mUsername;        
        private string mPassword;

        public string UserName
        {
            get { return mUsername; }
            set { mUsername = value; }
        }        

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public OnSignInEventArgs(string userName, string password) : base()
        {
            UserName = userName;
            Password = password;
        }
    }
   public class dialog_SignIn: DialogFragment
    {
        private EditText mTxtUserName_SignIn;
        private EditText mTxtPassword_SignIn;
        private Button mBtnSignIn;

        public event EventHandler<OnSignInEventArgs> mOnSignInComplete;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.dialog_sign_in, container, false);

            mTxtUserName_SignIn = view.FindViewById<EditText>(Resource.Id.txtUserName_SignIn);
            mTxtPassword_SignIn = view.FindViewById<EditText>(Resource.Id.txtPassword_SignIn);
            mBtnSignIn = view.FindViewById<Button>(Resource.Id.btnDialogSignIn);

            mBtnSignIn.Click += mBtnSignIn_Click;

            return view;
        }

        void mBtnSignIn_Click(object sender, EventArgs e)
        {
            //User has clicked the sign up button
            mOnSignInComplete.Invoke(this, new OnSignInEventArgs(mTxtUserName_SignIn.Text, mTxtPassword_SignIn.Text));
            this.Dismiss();
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            Dialog.Window.RequestFeature(WindowFeatures.NoTitle); //Sets the title bar to invisible
            base.OnActivityCreated(savedInstanceState);
            Dialog.Window.Attributes.WindowAnimations = Resource.Style.dialog_animation; //set the animation
        }
    }
}