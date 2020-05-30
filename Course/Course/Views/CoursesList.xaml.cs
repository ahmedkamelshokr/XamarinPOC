using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Course.Models;
using Course.Views;
using Course.ViewModels;

namespace Course.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class CoursesList : ContentPage
    {
       public CoursesListViewModel viewModel { get; set; }

        public CoursesList()
        {
            InitializeComponent();
            viewModel = new CoursesListViewModel(Navigation);
            BindingContext = viewModel;
        }

         protected override void OnAppearing()
        {
            base.OnAppearing();
         
            if (viewModel.Courses.Count == 0)
                viewModel.IsBusy = true;
        }

        private void searchCourses_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}