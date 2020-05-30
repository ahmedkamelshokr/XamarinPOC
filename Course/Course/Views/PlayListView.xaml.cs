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