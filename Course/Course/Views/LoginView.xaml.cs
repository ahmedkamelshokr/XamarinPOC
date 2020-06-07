using Course.ViewModels;

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