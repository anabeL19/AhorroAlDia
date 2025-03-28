using SmartSave.Views.GeneralInformation;
using SmartSave.Views.SavingsGoal;

namespace SmartSave
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            // General Information
            Routing.RegisterRoute("Information", typeof(SavingInfoPage));
            Routing.RegisterRoute("Options", typeof(SavingOptionPage));
            Routing.RegisterRoute("Test", typeof(TestPage));

            //Savings Goal
            Routing.RegisterRoute("GoalLevel", typeof (GoalLevelsPage));
            Routing.RegisterRoute("Goal", typeof (GoalPage));
            Routing.RegisterRoute("SavingsAccount", typeof (SavingsAccountPage));
            Routing.RegisterRoute("InfoTransaction", typeof (InfoTransactionPage));
            Routing.RegisterRoute("GraphTransaction", typeof (GraphTransactionPage));

            //Savings Club Game

        }
    }
}
