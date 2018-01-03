using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Instagram.UITests.PageObjects
{
	public partial class WelcomePage : BasePage<WelcomePage>
	{
		readonly Func<AppQuery, AppQuery> _signUpButton = e => e.Marked("SignUpButton");

		WelcomePage(IApp app) : base(app) { }

		public static WelcomePage Build(IApp app) => new WelcomePage(app);
		
		public LoginPage TapSignUp()
		{
			App.Tap(_signUpButton);
			return LoginPage.Build(App)
							.WaitForPageLoad();
		}

		public override WelcomePage WaitForPageLoad()
		{
			App.WaitForElement(_signUpButton);
			return this;
		}
	}
}
