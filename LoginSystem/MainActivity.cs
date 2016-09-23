﻿using System;
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
         protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.btnSignIn);
            TextView TesttextView = FindViewById<TextView>(Resource.Id.helloLabel);
            button.Click += delegate
            {
                TesttextView.Text = "Button Pressed";
            };




        }
    }
}

