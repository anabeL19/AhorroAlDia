using System.Globalization;
using System.Reflection;

namespace SmartSave.ViewModels.Base
{
    public static class ViewModelLocator
    {
        public static readonly BindableProperty AutoWireViewModelProperty =
           BindableProperty.CreateAttached("AutoWireViewModel", typeof(bool), typeof(ViewModelLocator), default(bool), propertyChanged: OnAutoWireViewModelChanged);

        public static bool GetAutoWireViewModel(BindableObject bindable)
        {
            return (bool)bindable.GetValue(ViewModelLocator.AutoWireViewModelProperty);
        }

        public static void SetAutoWireViewModel(BindableObject bindable, bool value)
        {
            bindable.SetValue(ViewModelLocator.AutoWireViewModelProperty, value);
        }

        private static void OnAutoWireViewModelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as Element;
            if (view == null)
            {
                return;
            }

            var viewType = view.GetType();
            var viewName = viewType.FullName.Replace(".Views.", ".ViewModels.");
            var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
            var viewModelName = string.Format(CultureInfo.InvariantCulture, "{0}ViewModel, {1}", viewName, viewAssemblyName);

            var viewModelType = Type.GetType(viewModelName);
            if (viewModelType == null)
            {
                return;
            }

            var viewModel = Application.Current.MainPage.Handler.MauiContext.Services.GetService(viewModelType);

            view.BindingContext = viewModel;

            EventHandler appearing = (s, e) =>
            {
                var _viewModel = viewModel as BaseViewModel;
                _viewModel?.OnInitializedAsync(new InitializedEventArgs(_viewModel?.Data));
            };

            (view as ContentPage).Appearing += appearing;

            (view as ContentPage).Disappearing += (s, e) =>
            {
                (view as ContentPage).Appearing -= appearing;
            };
        }
    }
}
