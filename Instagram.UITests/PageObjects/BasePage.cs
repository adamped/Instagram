using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Instagram.UITests.PageObjects
{
	public abstract class BasePage<T>
	{
		protected IApp App { get; set; }
		public BasePage(IApp app) => App = app;
		public abstract T WaitForPageLoad();
		
		public void EnterText(Func<AppQuery, AppQuery> element, string text)
		{
			App.Tap(element);
			App.EnterText(text);
		}
	}
}
