namespace Cap;

public partial class FindIdPage : ContentPage
{
	public FindIdPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		ErrMess.IsVisible = true;
        Shell.Current.GoToAsync(nameof(CheckInfoPage));
    }
}