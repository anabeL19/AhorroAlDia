namespace SmartSave.Controls
{
    public class CustomEntry : Entry
    {
        public static BindableProperty CursorColorProperty = BindableProperty.Create(nameof(CursorColor), typeof(Color), typeof(CustomEntry), Colors.Black);

        public Color CursorColor
        {
            get => (Color)GetValue(CursorColorProperty);
            set => SetValue(CursorColorProperty, value);
        }

        public CustomEntry()
        {
//#if ANDROID
//            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
//            {
//                handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
//            });
//#endif
        }
    }

}
