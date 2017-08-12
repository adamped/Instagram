using Exrin.Abstraction;
using Exrin.Framework;
using Instagram.Proxy;
using Instagram.ViewModel;
using Instagram.Views;

namespace Instagram
{
	/// <summary>
	/// A stack is a collection of page in the same navigation sequence. e.g. You can freely navigate between these pages.
	/// </summary>
	public class AuthenticationStack : BaseStack
	{
		public AuthenticationStack(IViewService viewService)
            : base(new NavigationProxy(), viewService, Stacks.Authentication, nameof(AuthenticationViews.Login))
        {
			ShowNavigationBar = false;
		}

		protected override void Map()
		{
			base.NavigationMap<Login, LoginViewModel>(nameof(AuthenticationViews.Login));
			base.NavigationMap<Welcome, WelcomeViewModel>(nameof(AuthenticationViews.Welcome));
		}
	}
}
