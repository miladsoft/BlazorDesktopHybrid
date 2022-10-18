using System;
using System.Windows.Forms;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using BlazorServerApp.Data;
using BlazorClassLibrary;

namespace WinFormsApp;

public partial class Form1 : Form
{
	// NOTE: Your machine should have `WebView2 Runtime` installed
	// https://developer.microsoft.com/en-us/microsoft-edge/webview2/
	// Otherwise you will get this error: System.IO.FileNotFoundException: The system cannot find the file specified. (0x80070002)
	
	private readonly AppState _appState = new();
	
    public Form1()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddBlazorWebView();
		serviceCollection.AddSingleton<AppState>(_appState);
        serviceCollection.AddSingleton<WeatherForecastService>();
	
        InitializeComponent();
		
        blazorWebView1.HostPage = @"wwwroot\index.html";
        blazorWebView1.Services = serviceCollection.BuildServiceProvider();
        blazorWebView1.RootComponents.Add<App>("#app");

        //blazorWebView1.Dock = DockStyle.Fill;		
    }
	
	private void button1_Click(object sender, EventArgs e)
	{
		MessageBox.Show(
			owner: this,
			text: $"Current counter value is: {_appState.Counter}",
			caption: "Counter");
	}	
}
