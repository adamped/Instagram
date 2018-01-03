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
using Xunit;
using Instagram.Droid.Renderers;

namespace Instagram.Android.UnitTests
{
	public class RendererTest
	{
		[Fact]
		public void Test_Renderer()
		{
			var renderer = new TextViewCustomRenderer();

			renderer.SetElement(new Xamarin.Forms.Entry());

			Assert.Equal(renderer.Control.PaddingLeft, 10);
		}

	}
}