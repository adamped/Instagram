using Exrin.Abstraction;
using System;
using Xamarin.Forms;

namespace Instagram.Proxy
{
	/// <summary>
	/// Implements IView on all ContentPages. ALL your views must inherit from this proxy.
	/// </summary>
	public class PageProxy: ContentPage, IView
	{
		protected override bool OnBackButtonPressed()
		{
			return ((IView)this).OnBackButtonPressed();
		}

		Func<bool> IView.OnBackButtonPressed { get; set; }
	}
}
