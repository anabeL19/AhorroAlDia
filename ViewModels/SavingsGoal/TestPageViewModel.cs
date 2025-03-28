using CommunityToolkit.Mvvm.Input;
using SmartSave.ViewModels.Base;

namespace SmartSave.ViewModels.SavingsGoal
{
    public partial class TestPageViewModel : BaseViewModel
    {
        public TestPageViewModel() { }
        [RelayCommand]
        public async Task GoToTodayEarnings()
        {
            IsBusy = true;
            await Shell.Current.GoToAsync($"Goal");
            //await Shell.Current.GoToAsync($"GraphTransactions");
            IsBusy = false;
        }
    }
}
