using Course.Models;
using Course.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Course.ViewModels
{
    public class CourseViewModel : BaseViewModel
    {

        //change to make data changes reflect to the ui  
        public CourseModel CourseModel { get; set; } = new CourseModel();

       public Command AddToPlaylistCommand { get { return   new Command(AddToPlaylist); } }


        public CourseViewModel(CourseModel course,INavigation Navigation) : base(Navigation)
        {
            CourseModel = course;

        }

        private void AddToPlaylist()
        {
            PlayListService.TempPlayList.Add(CourseModel);
        }

    }
}
