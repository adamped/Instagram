using Exrin.Abstraction;
using Exrin.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Instagram.Proxy
{
	/// <summary>
	/// This connects the INavigationProxy that Exrin uses, to a Xamarin Forms NavigationPage
	/// </summary>
    public class NavigationProxy : INavigationProxy
    {

        private NavigationPage _page = null;
        public event EventHandler<IViewNavigationArgs> OnPopped;
        private Queue<object> _argQueue = new Queue<object>();
        public VisualStatus ViewStatus { get; set; } = VisualStatus.Unseen;

		public NavigationProxy()
		{
			_page = new NavigationPage();
			_page.Popped += _page_Popped;
		}

        public NavigationProxy(NavigationPage page)
        {
            _page = page;
            _page.Popped += _page_Popped;
        }

        private void _page_Popped(object sender, NavigationEventArgs e)
        {
            if (OnPopped != null)
            {
                var poppedPage = e.Page as IView;
				var currentPage = _page.CurrentPage as IView;
                var parameter = _argQueue.Count > 0 ? _argQueue.Dequeue() : null;
                OnPopped(this, new ViewNavigationArgs() { Parameter = parameter, CurrentView = currentPage, PoppedView = poppedPage });
            }
        }

        public void SetNavigationBar(bool isVisible, object page)
        {
            var bindableObject = page as BindableObject;
            if (bindableObject != null)
                NavigationPage.SetHasNavigationBar(bindableObject, isVisible);
        }

        public object NativeView { get { return _page; } }

        public bool CanGoBack()
        {
            return _page.Navigation.NavigationStack.Count > 1;
        }

        public async Task PopAsync(object parameter)
        {
            _argQueue.Enqueue(parameter);
            await _page.PopAsync();
        }

        public async Task PopAsync()
        {
            await _page.PopAsync();
        }

        public async Task PushAsync(object page)
        {
            var xamarinPage = page as Page;

            if (xamarinPage == null)
                throw new Exception("PushAsync can not push a non Xamarin Page");

            await _page.PushAsync(xamarinPage);
        }

        public async Task ShowDialog(IDialogOptions dialogOptions)
        {
            if (ViewStatus == VisualStatus.Visible)
            {
                await _page.DisplayAlert(dialogOptions.Title, dialogOptions.Message, "OK");
                dialogOptions.Result = true;
            }
            else
            {
                throw new Exception("You can not call ShowDialog on a non-visible page");
            }
        }

        public Task ClearAsync()
        {
            _page = new NavigationPage();
            return Task.FromResult(true);
        }

        public Task SilentPopAsync(int indexFromTop)
        {
			var page = _page.Navigation.NavigationStack[_page.Navigation.NavigationStack.Count - indexFromTop - 1];
			_page.Navigation.RemovePage(page);
			 return Task.FromResult(true);
        }
    }
}
