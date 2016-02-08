using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace CustomDrawer
{
	public class App : Application
	{
		public static MasterDetailPage MasterDetailPage;

		public App ()
		{
			var detailContent = new ContentPage {BackgroundColor = Color.Green};
			var detailPage = new NavigationPage (detailContent);
			//detailPage.BarBackgroundColor = Color.Olive;
			detailPage.Title = "Some test";
			MasterDetailPage = new CustomMasterDetail {
				Master = new ContentPage{
					Title = "Some test",
					BackgroundColor = Color.Red
				},
				Detail = detailPage,
				Title = "Some test",
			};

			MainPage = MasterDetailPage;

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

