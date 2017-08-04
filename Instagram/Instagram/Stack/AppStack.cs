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
	public class AppStack : BaseStack
	{
		public AppStack(IViewService viewService)
            : base(new NavigationProxy(), viewService, Stacks.App, nameof(AppViews.Main))
        {
			ShowNavigationBar = true;
		}

		protected override void Map()
		{
			base.NavigationMap<MainPage, MainViewModel>(nameof(AppViews.Main));
			base.NavigationMap<AboutPage, AboutViewModel>(nameof(AppViews.About));
		}
	}
}
