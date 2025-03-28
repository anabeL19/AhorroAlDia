#if ANDROID
using Android.App;
using Android.Widget;
using AndroidX.AppCompat.Widget;
#endif
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace SmartSave.Controls.Handlers
{
#if ANDROID
    public class CustomDatePickerHandler : DatePickerHandler
    {
        MauiDatePicker _datePicker;

        public CustomDatePickerHandler()
        {
            Mapper.AppendToMapping(nameof(CustomDatePickerHandler), MapDatePicker);
        }

        private void MapDatePicker(IDatePickerHandler pickerHandler, IDatePicker picker)
        {
            if (picker is CustomDatePicker customPicker && pickerHandler is CustomDatePickerHandler customPickerHandler)
            {
                SetChanges(customPicker);
            }
        }

        protected override MauiDatePicker CreatePlatformView()
        {
            _datePicker = base.CreatePlatformView();
            return _datePicker;
        }

        internal void SetChanges(CustomDatePicker datePickerCustom)
        {
            _datePicker.SetTextColor(Android.Graphics.Color.ParseColor("#BABABA"));
            _datePicker.SetBackgroundColor(Android.Graphics.Color.Transparent);

        }
    }
#else
    public class CustomDatePickerHandler : DatePickerHandler
    {

    }
#endif

}
