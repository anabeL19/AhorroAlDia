using CommunityToolkit.Mvvm.Input;
using SmartSave.ViewModels.Base;

namespace SmartSave.ViewModels.SavingsGoal
{
    public partial class GoalPageViewModel: BaseViewModel
    {
        public GoalPageViewModel() 
        { }

        [RelayCommand]
        public async Task GoToSavingsAccount()
        {
            IsBusy = true;
            await Shell.Current.GoToAsync($"SavingsAccount");
            IsBusy = false;
        }
    }
}
