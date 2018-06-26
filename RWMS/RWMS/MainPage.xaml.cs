using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RWMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
           await Application.Current.MainPage.Navigation.PushModalAsync(new DashboardPage());
        }

        private async void btnExit_Clicked(object sender, EventArgs e)
        {
           await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
