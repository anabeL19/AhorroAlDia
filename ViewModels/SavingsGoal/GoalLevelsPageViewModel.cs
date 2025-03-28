using CommunityToolkit.Mvvm.Input;
using SmartSave.ViewModels.Base;

namespace SmartSave.ViewModels.SavingsGoal
{
    public partial class GoalLevelsPageViewModel: BaseViewModel
    {
        public GoalLevelsPageViewModel() 
        { 
        }

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
        public async Task GoToGoal()
        {
            IsBusy = true;
            await Shell.Current.GoToAsync("Goal");
            IsBusy = false;
        }

    }
}
