using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace LoginSystem
{
    [Activity(Label = "", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button mButton;

         protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mButton = FindViewById<Button>(Resource.Id.btnSignUp);
            mButton.Click += mButtonClick;      
           
         }

        void mButtonClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SignUp));
            this.StartActivity(intent);

        }

    }
}

