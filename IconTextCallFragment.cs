
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Support = Android.Support.V4.App.Fragment;


namespace TabbedApp
{
    public class IconTextCallFragment : Android.Support.V4.App.Fragment
    {



        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {


            // Use this to return your custom view for this Fragment 
            View view = inflater.Inflate(Resource.Layout.IconTxtCallLayout, container, false);
            var textView = view.FindViewById<TextView>(Resource.Id.clickable_text_view);
            var textView1 = view.FindViewById<TextView>(Resource.Id.clickable_text_view);
            textView.Click += StartNewActivity;
           
            //String strtext = Arguments.GetString("edttext");
            return view;

        }



        private void StartNewActivity(object sender, EventArgs e)
        {

            Intent intent = new Intent(this.Activity, typeof(Activity1));
            this.StartActivity(intent);
            Activity.OverridePendingTransition(Resource.Animation.BounceTop, Resource.Animation.Slide_out);


        }
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

           
            Bundle bundle = Arguments;
            if (bundle != null)
            {


                //(bundle.GetString("link"));
                
            }
        }

    }
}


    