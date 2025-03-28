#if ANDROID
using AndroidX.AppCompat.Widget;
#endif
using Microsoft.Maui;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSave.Controls.Handlers
{
#if ANDROID
    public sealed partial class CustomPickerHandler : PickerHandler
    {
        MauiPicker _picker;

        public CustomPickerHandler()
        {
            Mapper.AppendToMapping(nameof(CustomPickerHandler), MapDatePicker);
        }

        private void MapDatePicker(IPickerHandler pickerHandler, IPicker picker)
        {
            if (picker is Picker customPicker && pickerHandler is CustomPickerHandler customPickerHandler)
            {
                SetChanges(customPicker);
            }
        }

        protected override MauiPicker CreatePlatformView()
        {
            _picker = base.CreatePlatformView();
            return _picker;
        }

        internal void SetChanges(Picker pickerCustom)
        {
            _picker.SetBackgroundColor(Android.Graphics.Color.Transparent);
            _picker.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);

        }
    }
#else
    public partial class CustomPickerHandler : PickerHandler
    {
    }
#endif
}
