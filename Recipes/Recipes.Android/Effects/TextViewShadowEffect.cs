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
using Recipes.Droid.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("com.codemilltech")]
[assembly: ExportEffect(typeof(TextViewShadowEffect), "ShadowEffect")]
namespace Recipes.Droid.Effects
{

    public class TextViewShadowEffect : PlatformEffect
    {
        UIColor oldColor;
        

        protected override void OnAttached()
        {
            var c = Control as TextView;


        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}