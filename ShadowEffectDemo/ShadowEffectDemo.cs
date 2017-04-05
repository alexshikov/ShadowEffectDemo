using System;

using Xamarin.Forms;

namespace ShadowEffectDemo
{
	public class App: Application
	{
		public App ()
		{
			// The root page of your application
			var content = new ContentPage
			{
				Title = "ShadowEffectDemo",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
				}
			};

			var sideMenu = new ContentPage
			{
				Title = "Menu",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "This is your side menu"
						}
					}
				}
			};

			MainPage = new MasterDetailPage ()
			{
				Detail = new ShadowNavigationPage (content),
				Master = sideMenu,
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
