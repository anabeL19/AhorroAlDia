using Microsoft.Extensions.Logging;
using SmartSave.Controls;
using SmartSave.Controls.Handlers;
using SmartSave.Services;
using SmartSave.ViewModels.GeneralInformation;
using SmartSave.ViewModels.SavingsGoal;
using SmartSave.Views.GeneralInformation;
using SmartSave.Views.SavingsGoal;
using Telerik.Maui.Controls.Compatibility;

namespace SmartSave
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseTelerik()
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .RegisterServices()
                .RegisterHandlers()
                .RegisterViewModels()
                .RegisterViews();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<ILevelService, LevelService>();
            return builder;
        }

        public static MauiAppBuilder RegisterHandlers(this MauiAppBuilder builder)
        {
            builder.ConfigureMauiHandlers(handlers =>
            {
                handlers.AddHandler(typeof(CustomEntry), typeof(CustomEntryHandler));
                handlers.AddHandler(typeof(CustomDatePicker), typeof(CustomDatePickerHandler));
                handlers.AddHandler(typeof(Picker), typeof(CustomPickerHandler));
            });
            return builder;
        }

        //public static MauiAppBuilder RegisterHelpers(this MauiAppBuilder builder)
        //{
        //    builder.Services.AddTransient<IRequestProvider, RequestProvider>();

        //    return builder;
        //}

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            //General Information
            builder.Services.AddTransient<SavingInfoPageViewModel>();
            builder.Services.AddTransient<SavingOptionPageViewModel>();
            builder.Services.AddTransient<TestPageViewModel>();

            //Savings Goal
            builder.Services.AddTransient<GoalLevelsPageViewModel>();
            builder.Services.AddTransient<GoalPageViewModel>();
            builder.Services.AddTransient<SavingsAccountPageViewModel>();
            builder.Services.AddTransient<InfoTransactionPageViewModel>();
            builder.Services.AddTransient<GraphTransactionPageViewModel>();

            //Savings Club Game

            return builder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
        {
            //General Information
            builder.Services.AddTransient<SavingInfoPage>();
            builder.Services.AddTransient<SavingOptionPage>();
            builder.Services.AddTransient<TestPage>();

            //Savings Goal
            builder.Services.AddTransient<GoalLevelsPage>();
            builder.Services.AddTransient<GoalPage>();
            builder.Services.AddTransient<SavingsAccountPage>();
            builder.Services.AddTransient<InfoTransactionPage>();
            builder.Services.AddTransient<GraphTransactionPage>();

            //Savings Club Game

            return builder;
        }
    }
}
