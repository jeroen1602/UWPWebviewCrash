using System;
using Windows.UI.Xaml.Controls;

namespace WebViewCrash
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Webview.UnsupportedUriSchemeIdentified += Webview_UnsupportedUriSchemeIdentified;
            Webview.Navigate(new Uri("http://localhost:3000"));
        }

        private void Webview_UnsupportedUriSchemeIdentified(WebView sender, WebViewUnsupportedUriSchemeIdentifiedEventArgs args)
        {
            // Should be handled here.
            args.Handled = true;
        }
    }
}
