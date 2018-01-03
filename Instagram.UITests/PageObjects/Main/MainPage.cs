using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Instagram.UITests.PageObjects
{
	public class MainPage : BasePage<MainPage>
	{
		readonly Func<AppQuery, AppQuery> _loginButton = e => e.Marked("LoginButton");
		readonly Func<AppQuery, AppQuery> _usernameEntry = e => e.Marked("UsernameEntry");
		readonly Func<AppQuery, AppQuery> _passwordEntry = e => e.Marked("PasswordEntry");
		MainPage(IApp app) : base(app) { }

		public static MainPage Build(IApp app) => new MainPage(app);


		public override MainPage WaitForPageLoad()
		{
			App.WaitForElement(_loginButton);
			return this;
		}
	}
}
