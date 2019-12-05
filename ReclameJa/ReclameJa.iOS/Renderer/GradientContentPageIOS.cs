using ReclameJa.iOS.Renderer;
using ReclameJa.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(GradientContentPage), typeof(GradientContentPageIOS))]
namespace ReclameJa.iOS.Renderer
{
    public class GradientContentPageIOS : VisualElementRenderer<StackLayout>
    {
        public GradientContentPageIOS()
        {
            GradientContentPage stack1 = new GradientContentPage()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                StartColor = Color.FromHex("#c7cee0"),
                EndColor = Color.FromHex("#684fb4")
            };
        }


    }
}