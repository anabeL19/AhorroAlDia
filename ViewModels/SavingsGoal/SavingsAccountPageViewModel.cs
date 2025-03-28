using CommunityToolkit.Mvvm.Input;
using SmartSave.ViewModels.Base;

namespace SmartSave.ViewModels.SavingsGoal
{
    public partial class SavingsAccountPageViewModel: BaseViewModel
    {
        public SavingsAccountPageViewModel() 
        { }

        [RelayCommand]
        public async Task GoToTodayEarnings()
        {
            IsBusy = true;
            await Shell.Current.GoToAsync($"InfoTransaction");
            IsBusy = false;
        }
    }
}
