using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Instagram.UITests.PageObjects
{
	public class LoginPage : BasePage<LoginPage>
	{
		readonly Func<AppQuery, AppQuery> _loginButton = e => e.Marked("LoginButton");
		readonly Func<AppQuery, AppQuery> _usernameEntry = e => e.Marked("UsernameEntry");
		readonly Func<AppQuery, AppQuery> _passwordEntry = e => e.Marked("PasswordEntry");
		LoginPage(IApp app) : base(app) { }

		public static LoginPage Build(IApp app) => new LoginPage(app);

		public MainPage Login(string username, string password)
		{
			base.EnterText(_usernameEntry, username);
			base.EnterText(_passwordEntry, password);

			App.Tap(_loginButton);

			return MainPage.Build(App)
						   .WaitForPageLoad();
		}

		public override LoginPage WaitForPageLoad()
		{
			App.WaitForElement(_loginButton);
			return this;
		}
	}
}
