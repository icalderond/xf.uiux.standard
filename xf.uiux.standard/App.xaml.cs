using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xf.uiux.standard.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace xf.uiux.standard
{
    public partial class App : PrismApplication
    {
        public App() { }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<OnboardingPage>("Onboarding");
        }

        protected async override void OnInitialized()
        {
            InitializeComponent();
            //Sogaso - Onboarding + Login App 
            //Portfolio: Dribbble.com/sogaso
            await NavigationService.NavigateAsync("Onboarding");

        }
    }
}
