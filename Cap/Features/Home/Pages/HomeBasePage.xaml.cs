namespace Cap;

public partial class HomeBasePage : ContentPage
{
    TabHomeBaseViewModel _viewModel;
	public HomeBasePage()
	{
        _viewModel = new TabHomeBaseViewModel();
		InitializeComponent();
        BindingContext = _viewModel;
        Story_Clicked(null, null);
        //DataTemplate data = new TabHome();

        //BindableLayout.SetItemTemplate(abc, data);
        //BindableLayout.SetItemsSource(abc, _viewModel.Items);
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

    private void Story_Clicked(object sender, EventArgs e)
    {
        //Frame frame = this.Parent as Frame;
        story.BackgroundColor = Color.FromHex("#739EF1");
        story.BorderColor = Color.FromHex("#739EF1");
        buttonStory.BackgroundColor = Color.FromHex("#739EF1");
        buttonStory.TextColor = Colors.White;

        Home.BackgroundColor = Color.FromHex("#575FCC");
        Home.BorderColor = Color.FromHex("#575FCC");
        buttonHome.BackgroundColor = Color.FromHex("#575FCC");
        buttonHome.TextColor = Color.FromHex("#739EF1");
    }

    private void Home_Clicked(object sender, EventArgs e)
    {
        Home.BackgroundColor = Color.FromHex("#739EF1");
        Home.BorderColor= Color.FromHex("#739EF1");
        buttonHome.BackgroundColor = Color.FromHex("#739EF1");
        buttonHome.TextColor = Colors.White;

        story.BackgroundColor = Color.FromHex("#575FCC");
        story.BorderColor = Color.FromHex("#575FCC");
        buttonStory.BackgroundColor = Color.FromHex("#575FCC");
        buttonStory.TextColor = Color.FromHex("#739EF1");
    }
}