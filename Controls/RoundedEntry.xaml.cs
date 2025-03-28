namespace SmartSave.Controls;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class RoundedEntry : ContentView
{

    public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.Create(nameof(HorizontalTextAlignment), typeof(TextAlignment), typeof(RoundedEntry), TextAlignment.Start);
    public static readonly BindableProperty FontSizeProperty = BindableProperty.Create(nameof(FontSize), typeof(int), typeof(RoundedEntry), 16);
    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(RoundedEntry), string.Empty, BindingMode.TwoWay);
    public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(RoundedEntry), string.Empty);
    public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(nameof(IsPassword), typeof(bool), typeof(RoundedEntry), false);
    public static BindableProperty CursorColorProperty = BindableProperty.Create(nameof(CursorColor), typeof(Color), typeof(CustomEntry), Colors.Black);
    public static BindableProperty PlaceholderColorProperty = BindableProperty.Create(nameof(PlaceholderColor), typeof(Color), typeof(CustomEntry), Colors.Gray);
    public static BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(CustomEntry), Colors.Black);
    public static BindableProperty BackgroundColorInputProperty = BindableProperty.Create(nameof(BackgroundColorInput), typeof(Color), typeof(CustomEntry), Colors.White);
    public static BindableProperty BackgroundColorInputInProperty = BindableProperty.Create(nameof(BackgroundColorInputIn), typeof(Color), typeof(CustomEntry), Colors.White);
    public static readonly BindableProperty IsUserNameProperty = BindableProperty.Create(nameof(IsUserName), typeof(bool), typeof(RoundedEntry), false);

    public TextAlignment HorizontalTextAlignment
    {
        get => (TextAlignment)GetValue(HorizontalTextAlignmentProperty);
        set => SetValue(HorizontalTextAlignmentProperty, value);
    }
    public int FontSize
    {
        get => (int)GetValue(FontSizeProperty);
        set => SetValue(FontSizeProperty, value);
    }

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }
    public bool IsPassword
    {
        get => (bool)GetValue(IsPasswordProperty);
        set => SetValue(IsPasswordProperty, value);
    }

    public bool IsUserName
    {
        get => (bool)GetValue(IsUserNameProperty);
        set => SetValue(IsUserNameProperty, value);
    }

    public Color CursorColor
    {
        get => (Color)GetValue(CursorColorProperty);
        set => SetValue(CursorColorProperty, value);
    }
    public Color PlaceholderColor
    {
        get => (Color)GetValue(PlaceholderColorProperty);
        set => SetValue(PlaceholderColorProperty, value);
    }
    public Color TextColor
    {
        get => (Color)GetValue(TextColorProperty);
        set => SetValue(TextColorProperty, value);
    }
    public Color BackgroundColorInput
    {
        get => (Color)GetValue(BackgroundColorInputProperty);
        set => SetValue(BackgroundColorInputProperty, value);
    }
    public Color BackgroundColorInputIn
    {
        get => (Color)GetValue(BackgroundColorInputInProperty);
        set => SetValue(BackgroundColorInputInProperty, value);
    }

    public RoundedEntry()
    {
        InitializeComponent();
    }


    private void ImageButton_Clicked(object sender, System.EventArgs e)
    {
        (sender as ImageButton).Source = passwordEntry.IsPassword ? "noview.png" : "view.png";
        passwordEntry.IsPassword = !passwordEntry.IsPassword;
    }

}