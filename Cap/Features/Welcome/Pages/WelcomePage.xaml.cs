using CommunityToolkit.Maui.Views;

namespace Cap;

public partial class WelcomePage : ContentPage
{
    WelcomePageViewModel viewModel;
	public WelcomePage()
	{
        viewModel = new WelcomePageViewModel();
		InitializeComponent();
        BindingContext = viewModel;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();

    }

    private void Button_Continue(object sender, EventArgs e)
    {
        if(indicatorView.Position + 1 < indicatorView.Count)
        {
            indicatorView.Position = indicatorView.Position + 1;
        }
        if (indicatorView.Position == indicatorView.Count -1)
        {

            Navigation.PushAsync(new LoginPage());
        }

    }

    [Obsolete]
    private void indicatorView_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (indicatorView.Position == indicatorView.Count - 1)
        {
            ButtonContinue.Text = "Bắt đầu";
            ButtonContinue.BackgroundColor = Color.FromHex("#FF5C9E");
        }
        else
        {
            ButtonContinue.Text = "Tiếp tục";
            ButtonContinue.BackgroundColor = Color.FromHex("#575FCC");
        }

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

        //var popup = new popupCommon();

        //this.ShowPopup(popup);
        Navigation.PushAsync(new LoginPage());
    }
}