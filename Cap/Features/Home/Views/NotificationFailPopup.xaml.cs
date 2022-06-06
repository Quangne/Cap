using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Views;
namespace Cap;

public partial class NotificationFailPopup 
{
	public NotificationFailPopup()
	{
		InitializeComponent();
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {
		Close();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Close();
    }
}