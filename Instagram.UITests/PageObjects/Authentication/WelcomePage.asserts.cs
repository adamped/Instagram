using NUnit.Framework;
using System;
using System.Linq;
using Xamarin.UITest;

namespace Instagram.UITests.PageObjects
{
	public partial class WelcomePage
	{	
		public void AssertPageIsLoaded()
		{
			Assert.IsTrue(App.Query(_signUpButton).Any());
		}
	}
}
