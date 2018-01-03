using Exrin.Abstraction;
using Exrin.Framework;
using Instagram.Views;
using Xamarin.Forms;

namespace Instagram
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			// If you want to set specific platform only options, move this to each native platform project
			Exrin.Framework.App.Init();

			// Everything is setup, and the MainPage set here
			Bootstrapper.GetInstance()
						.Init()
						.Get<INavigationService>()
						.Navigate(new StackOptions()
						{
							StackChoice = Stacks.Authentication
						});

			

		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
