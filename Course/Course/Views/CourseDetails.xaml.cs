using Course.Models;
using Course.Services;
using Course.ViewModels;
using System;
using System.Collections.Generic;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Course.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CourseDetails : ContentPage
    {
        public CourseViewModel CourseModel { get; set; }
      

        public CourseDetails(  CourseModel course)
        {
            
            InitializeComponent();
            CourseModel = new CourseViewModel(course, Navigation);

            BindingContext = CourseModel;

        }


    }
}