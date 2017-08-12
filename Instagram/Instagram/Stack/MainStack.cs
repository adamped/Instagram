using Exrin.Abstraction;
using Exrin.Framework;
using Instagram.Proxy;
using Instagram.ViewModel;
using Instagram.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Instagram.Stack
{
    public class MainStack : BaseStack
	{
		public MainStack(IViewService viewService)
            : base(new NavigationProxy(), viewService, Stacks.Main, nameof(MainViews.Feed))
        {
			ShowNavigationBar = false;
		}
		protected override void Map()
		{
			base.NavigationMap<Feed, FeedViewModel>(nameof(MainViews.Feed));
		}
	}
}
