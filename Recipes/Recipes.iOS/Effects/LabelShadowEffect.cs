using CoreGraphics;
using Recipes.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("com.codemilltech")]
[assembly: ExportEffect(typeof(LabelShadowEffect), "ShadowEffect")]

namespace Recipes.iOS.Effects
{
    public class LabelShadowEffect : PlatformEffect
    {
        UIColor oldColor;
        CGSize oldOffset;

        protected override void OnAttached()
        {
            var c = Control as UILabel;
            oldColor = c.ShadowColor;
            oldOffset = c.ShadowOffset;

            c.ShadowColor = UIColor.Black;
            c.ShadowOffset = new CGSize(2, 2);
        }

        protected override void OnDetached()
        {
            var c = Control as UILabel;

            c.ShadowColor = oldColor;
            c.ShadowOffset = oldOffset;


        }
    }
}