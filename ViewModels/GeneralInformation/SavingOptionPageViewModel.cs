using CommunityToolkit.Mvvm.Input;
using SmartSave.Services;
using SmartSave.ViewModels.Base;

namespace SmartSave.ViewModels.GeneralInformation
{
    public partial class SavingOptionPageViewModel: BaseViewModel
    {
        public readonly ILevelService levelService;
        public SavingOptionPageViewModel() 
        {
            //this.levelService = _levelService;
            var constants = new Constantes.AppConstants();
            levelService = new LevelService(constants);

        }

        [RelayCommand]
        public async Task GoToLevelGoal()
        {
            try
            {
                var response = await this.levelService.GetLevels();
                IsBusy = true;
                await Shell.Current.GoToAsync($"GoalLevel");
                IsBusy = false;
            }
            catch { }
            
        }

        [RelayCommand]
        public async Task GoToSavingsClubGame()
        {
            IsBusy = true;
            await Shell.Current.GoToAsync($"");
            IsBusy = false;
        }
    }
}
