#if ANDROID
using AndroidX.AppCompat.Widget;
#endif

using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using System.Drawing;

#if IOS
using UIKit;  
#endif

namespace SmartSave.Controls.Handlers
{
#if ANDROID
    public sealed partial class CustomEntryHandler : EntryHandler
    {
        AppCompatEditText _nativeEntry;

        public CustomEntryHandler()
        {
            Mapper.AppendToMapping(nameof(CustomEntryHandler), MapCursorEntry);
        }

        private void MapCursorEntry(IEntryHandler entryHandler, IEntry entry)
        {
            if (entry is CustomEntry customEntry && entryHandler is CustomEntryHandler customEntryHandler)
            {
                SetCursorColor(customEntry);
            }
        }

        protected override AppCompatEditText CreatePlatformView()
        {
            _nativeEntry = new AppCompatEditText(Context);
            return _nativeEntry;
        }

        internal void SetCursorColor(CustomEntry entry)
        {
            _nativeEntry.SetBackgroundColor(Android.Graphics.Color.Transparent);
            _nativeEntry.SetPadding(20, 0, 0, 0);
            _nativeEntry.TextCursorDrawable.SetTint(entry.CursorColor.ToPlatform());
        }
    }

#elif IOS
    public sealed partial class CustomEntryHandler : EntryHandler
    {
        protected override void ConnectHandler(MauiTextField platformView)
        {
            base.ConnectHandler(platformView);

            // Crear un UIToolbar para contener el botón "Done"
            var toolbar = new UIToolbar(new RectangleF(0.0f, 0.0f, 50.0f, 44.0f));

            // Crear el botón "Done" y asociarlo a la acción de ocultar el teclado
            var doneButton = new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                this.PlatformView.EndEditing(true); // Forzar el cierre del teclado
            });

            // Añadir el botón "Done" al toolbar
            toolbar.Items = new UIBarButtonItem[]
            {
                new UIBarButtonItem (UIBarButtonSystemItem.FlexibleSpace), // Espacio flexible
                doneButton
            };

            // Asignar el toolbar como el accesorio de entrada para el teclado
            this.PlatformView.InputAccessoryView = toolbar;
        }
    }
#endif
}