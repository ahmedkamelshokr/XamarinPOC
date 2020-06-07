using Course.Models;
using Course.Services;
using Xamarin.Forms;

namespace Course.ViewModels
{
    public class CourseViewModel : BaseViewModel
    {

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
