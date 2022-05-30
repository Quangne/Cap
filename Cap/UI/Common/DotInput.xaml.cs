using System.Diagnostics.CodeAnalysis;

namespace Cap;
[ExcludeFromCodeCoverage]
public partial class DotInput
{
    public static readonly BindableProperty BackgroundColorProperty = BindableProperty.Create(
            nameof(BackgroundColor),
            typeof(Color),
            typeof(InputView));
    
    public DotInput()
	{
		InitializeComponent();
	}
    public Color BackgroundColor
    {
        get => (Color)GetValue(BackgroundColorProperty);
        set => SetValue(BackgroundColorProperty, value);
    }
    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var totalNew = e.NewTextValue.Length;
        var totalOld = e.OldTextValue?.Length == null ? 0 : e.OldTextValue.Length;
        if (totalNew > totalOld)
        {
            var image = ((Image)Text.FindByName("dotImage" + e.NewTextValue.Length.ToString()));
            image.IsVisible = false;
            var label = (Label)Text.FindByName("label" + e.NewTextValue.Length.ToString());
            label.Text = e.NewTextValue.ToArray()[e.NewTextValue.Length - 1].ToString();
        }
        else
        {
            var image = ((Image)Text.FindByName("dotImage" + e.OldTextValue.Length.ToString()));
            image.IsVisible = true;
            var label = (Label)Text.FindByName("label" + e.OldTextValue.Length.ToString());
            label.Text = "";
        }
    }
}