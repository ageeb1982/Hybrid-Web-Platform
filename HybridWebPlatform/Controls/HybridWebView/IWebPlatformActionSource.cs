using System;
using System.Threading.Tasks;
using HybridWebPlatform.HybridWeb.Contracts;

namespace HybridWebPlatform.HybridWeb
{
	public interface IWebPlatformActionSource
	{
		bool CanGoBack
		{
			get;
		}

		bool CanGoForward
		{
			get;
		}

		string CurrentUrl
		{
			get;
		}

		event Func<Uri, bool> PageLoadRequest;
		event Action<Uri> PageLoadStarted;
		event Action<Uri> PageLoadFinished;
		event Action<Uri, string, int> PageLoadError;
		event Action<string> JavascriptExecuted;

		void GoBack();
		void GoForward();
		void RefreshPage();
		void LoadPage(Uri page);
		void ExecuteJavascript(string javascript);
	}
}
