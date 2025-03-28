namespace SmartSave.Controls
{
    public class CustomDatePicker : DatePicker
    {
        public static BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(CustomDatePicker), string.Empty);

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }
    }
}
