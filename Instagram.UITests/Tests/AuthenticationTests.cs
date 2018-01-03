using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Instagram.UITests.Tests;
using Instagram.UITests.PageObjects;

namespace Instagram.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class AuthenticationTests: BaseTests
	{
		public AuthenticationTests(Platform platform) : base(platform) { }
		
		[Test]
		public void LoadWelcomePage()
		{
			var page = WelcomePage.Build(App)
								  .WaitForPageLoad();

			page.AssertPageIsLoaded();
		}
	}
}

