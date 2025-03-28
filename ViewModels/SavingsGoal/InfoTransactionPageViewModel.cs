using CommunityToolkit.Mvvm.Input;
using SmartSave.Model.SavingsGoal;
using SmartSave.ViewModels.Base;
using System.Collections.ObjectModel;

namespace SmartSave.ViewModels.SavingsGoal
{

    public partial class InfoTransactionPageViewModel: BaseViewModel
    {

        public InfoTransactionPageViewModel()
        {
        }

        [RelayCommand]
        public async Task GoToGraphTransaction()
        {
            IsBusy = true;
            await Shell.Current.GoToAsync($"GraphTransaction");
            IsBusy = false;
        }
        
    }
}
