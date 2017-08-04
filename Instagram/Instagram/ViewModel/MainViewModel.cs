using Exrin.Abstraction;
using Exrin.Framework;
using Instagram.Model;

namespace Instagram.ViewModel
{
	public class MainViewModel : Exrin.Framework.ViewModel
	{
		// One ViewModel per View is recommended but not enforced.

		private readonly IAppModel _model;
		public MainViewModel(IAppModel model)
		{
			_model = model;
		}

		// Using the special Get and Set methods will ensure INotifyPropertyChanged is implemented.
		public string HelloText { get { return Get<string>(); } set { Set(value); } }


		public IRelayCommand NavigationCommand
		{
			get
			{
				return GetCommand(() =>
				{
					return new RelayCommand(async (parameter) =>
					{
						await NavigationService.Navigate(nameof(AppViews.About));
					});
				});
			}
		}

		// Alternative Command using Operations
		// Operations allow easier unit testing, double click prevention and timeout's
		public IRelayCommand AboutCommand
		{
			get
			{
				return GetCommand(() =>
				{
					return Execution.ViewModelExecute((parameter, token) =>
					{
						return new NavigationResult(AppViews.About);
					});
				});
			}
		}

	}
}
