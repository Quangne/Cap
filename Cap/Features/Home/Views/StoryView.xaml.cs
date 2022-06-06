namespace Cap;

public partial class StoryView 
{
	public StoryView()
	{
		InitializeComponent();
	}

    private void Story_Clicked(object sender, EventArgs e)
    {

    }

    private void Home_Clicked(object sender, EventArgs e)
    {

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(CreateMilestonePage));
    }
}