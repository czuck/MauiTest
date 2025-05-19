using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanApp.Controls;

public class CustomWebView : WebView
{
    public CustomWebView()
    {
        Navigating += OnShouldLoad;
    }

    private async void OnShouldLoad(object sender, WebNavigatingEventArgs e)
    {
        if (e.Url.Contains("accounts"))
        {
            await Launcher.OpenAsync(new Uri(e.Url.Substring(0, e.Url.Length - 8)));
            e.Cancel = true;
            return;
        }
    }
}