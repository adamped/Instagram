using Exrin.Abstraction;
using Instagram.Proxy;
using System;
using Xamarin.Forms;

namespace Instagram
{
	/// <summary>
	/// Responsible for setting up all resources the application will use.
	/// </summary>
	public class Bootstrapper : Exrin.Framework.Bootstrapper
	{
		private static Bootstrapper _instance = null;
		public Bootstrapper(IInjectionProxy injection, Action<object> setRoot, Func<object> getRoot)
			: base(injection, setRoot, getRoot)
		{
		}

		public static Bootstrapper GetInstance()
		{
			if (_instance == null)
				_instance = new Bootstrapper(new Injection(),
											 (view) => Application.Current.MainPage = view as Page,
											 () => { return Application.Current.MainPage; });

			return _instance;
		}

	}
}
