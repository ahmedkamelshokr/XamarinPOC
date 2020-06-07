using Course.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayListView : ContentPage
    {
        public PlayListViewModel PlayListViewModel { get; set; }
        public PlayListView()
        {
            InitializeComponent();
            PlayListViewModel = new PlayListViewModel(Navigation);
            BindingContext = PlayListViewModel;
        }
    }
}