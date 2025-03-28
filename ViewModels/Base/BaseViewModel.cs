using CommunityToolkit.Mvvm.ComponentModel;

namespace SmartSave.ViewModels.Base
{
    public partial class BaseViewModel: ObservableObject
    {
        private event EventHandler<InitializedEventArgs> _initialized;
        public event EventHandler<InitializedEventArgs> Initialized
        {
            add { _initialized += value; }
            remove { _initialized -= value; }
        }

        [ObservableProperty]
        private bool isBusy;

        public object Data { get; set; }

        public virtual Task OnNavigatedTo()
        {
            return Task.CompletedTask;
        }

        public virtual void OnNavigatedFrom()
        {
        }

        public virtual void OnInitializedAsync(InitializedEventArgs e)
        {
            _initialized?.Invoke(this, e);
        }
    }
}
