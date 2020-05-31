using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Course.Services;
using Course.Views;

namespace Course
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<UserService>();
            DependencyService.Register<MockCourseModelStore>();
            MainPage = new NavigationPage(new LoginView());// new MainPage();
               //   var mainPage = new NavigationPage(new LoginView());

           // MainPage = mainPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
