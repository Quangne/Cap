using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Views;
namespace Cap;

public partial class InvitationPopup 
{
	public InvitationPopup()
	{
		InitializeComponent();
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Close(false);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Close(true);
    }
}