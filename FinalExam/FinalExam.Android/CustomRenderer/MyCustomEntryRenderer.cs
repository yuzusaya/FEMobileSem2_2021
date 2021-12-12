using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FinalExam.CustomRenderer;
using FinalExam.Droid.CustomRenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(MyCustomEntryRenderer))]
namespace FinalExam.Droid.CustomRenderer
{
    public class MyCustomEntryRenderer : EntryRenderer
    {
        public MyCustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = null;
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Q)
                {
                    Control.SetTextCursorDrawable(Resource.Drawable.my_cursor); //This API Intrduced in android 10
                }
                else
                {
                    IntPtr IntPtrtextViewClass = JNIEnv.FindClass(typeof(TextView));
                    IntPtr mCursorDrawableResProperty = JNIEnv.GetFieldID(IntPtrtextViewClass, "mCursorDrawableRes", "I");
                    JNIEnv.SetField(Control.Handle, mCursorDrawableResProperty, 0);
                }
               
            }
        }
    }
}