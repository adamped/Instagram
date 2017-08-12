using Android.Views;
using Instagram.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(TextViewCustomRenderer))]
namespace Instagram.Droid.Renderers
{
	public class TextViewCustomRenderer: EntryRenderer
	{

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.Background = Android.App.Application.Context.GetDrawable(Resource.Drawable.rounded_corners);
				Control.Gravity = GravityFlags.CenterVertical;
				Control.SetPadding(10, 0, 0, 0);
			}
		}

	}
}