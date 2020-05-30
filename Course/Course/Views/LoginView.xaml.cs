using Course.Models;
using Course.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {

        public LoginViewModel lginViewModel { get; set; }

        public LoginView()
        {
            InitializeComponent();
            lginViewModel = new LoginViewModel(this,Navigation);
            BindingContext = lginViewModel;
        }



    }
}