using Exrin.Abstraction;
using Exrin.Framework;

namespace Instagram.ViewModel
{
	/// <summary>
	/// This is a standard ViewModel.
	/// </summary>
	public class WelcomeViewModel : Exrin.Framework.ViewModel
	{
		public IRelayCommand LoginCommand
		{
			get
			{
				return GetCommand(() =>
				{
					return new RelayCommand(async (parameter) =>
					{
						await NavigationService.Navigate(nameof(AuthenticationViews.Login));
					});
				});
			}
		}
	}
}
