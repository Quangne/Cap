using System.Diagnostics.CodeAnalysis;

namespace Cap;
[ExcludeFromCodeCoverage]
public partial class InputView 
{
	public static readonly BindableProperty IconProperty = BindableProperty.Create(
            nameof(PrefixIcon),
            typeof(ImageSource),
            typeof(InputView));

    public static readonly BindableProperty PlaceholderTextProperty = BindableProperty.Create(
            nameof(PlaceholderText),
            typeof(string),
            typeof(InputView));

    public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(
            nameof(IsPassword),
            typeof(bool),
            typeof(InputView),false);

    public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(
            nameof(BorderColor),
            typeof(Color),
            typeof(InputView));
    public static readonly BindableProperty KeyboardTypeProperty = BindableProperty.Create(
            nameof(KeyboardType),
            typeof(Keyboard),
            typeof(InputView),
            Keyboard.Default);
    public InputView()
	{
		InitializeComponent();
	}
    public bool IsPassword
    {
        get => (bool)GetValue(IsPasswordProperty);
        set => SetValue(IsPasswordProperty, value);
    }
	public ImageSource PrefixIcon
    {
        get => (ImageSource)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
    public string PlaceholderText
    {
        get => (string)GetValue(PlaceholderTextProperty);
        set => SetValue(PlaceholderTextProperty, value);
    }
    public Color BorderColor
    {
        get => (Color)GetValue(BorderColorProperty);
        set => SetValue(BorderColorProperty, value);
    }
    public Keyboard KeyboardType
    {
        get => (Keyboard)GetValue(KeyboardTypeProperty);
        set => SetValue(KeyboardTypeProperty, value);
    }
    private void TextEntry_Focused(object sender, FocusEventArgs e)
    {
        TextBox.BorderColor = Color.FromHex("#68D1A2");
    }

    private void TextEntry_Unfocused(object sender, FocusEventArgs e)
    {
        TextBox.BorderColor = Colors.White;
    }
}