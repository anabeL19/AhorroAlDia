using CommunityToolkit.Mvvm.Input;
using SmartSave.ViewModels.Base;

namespace SmartSave.ViewModels.GeneralInformation
{
    public partial class SavingInfoPageViewModel: BaseViewModel
    {
        public SavingInfoPageViewModel() { }

        public override async void OnInitializedAsync(InitializedEventArgs e)
        {
            try
            {
                base.OnInitializedAsync(e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        [RelayCommand]
        public async Task GoToSavingOption()
        {
            IsBusy = true;
            await Shell.Current.GoToAsync($"Options");
            IsBusy = false;
        }

        [RelayCommand]
        public async Task GoToInfoTransactionGame()
        {
            IsBusy = true;
            await Shell.Current.GoToAsync($"InfoTransaction");
            IsBusy = false;
        }
    }
}
