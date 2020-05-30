using Course.Models;
using Course.Services;
using Course.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Course.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly UserService userService;
        private readonly Page page;

        public UserModel User { get; set; }

            public LoginViewModel(Page page,INavigation Navigation) : base(Navigation)
        {
            User = new UserModel();
            userService =new UserService();
            this.page = page;
        }

        public Command LoginCommand { get { return new Command(Login); } }

        private async void Login()
        {
            if (!ValidationHelper.IsFormValid(User, page)) { return; }

            if (userService.ValidateUser(User.Username, User.Password))
            {

                await App.Current.SavePropertiesAsync();

                // App.Current.MainPage.Navigation.InsertPageBefore(new MainPage(), App.Current.MainPage);

                //await App.Current.MainPage.Navigation.PopAsync();

                //var masterDetailPage = new MasterDetailPage()
                //{
                //    Master = new MainPage(),
                //    Detail = new NavigationPage(new CoursesList())
                //};

                //Application.Current.MainPage = masterDetailPage;

                Application.Current.MainPage = new NavigationPage(new MainPage());
            }
            else
                await App.Current.MainPage.DisplayAlert("Error", "Invalid login info", "ok");

        }
    }
}
