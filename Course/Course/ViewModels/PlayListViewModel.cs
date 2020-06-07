using Course.Models;
using Course.Services;
using System.Linq;
using Xamarin.Forms;

namespace Course.ViewModels
{
    public class PlayListViewModel : BaseViewModel
    {
        public UserModel User { get; set; }
        public PlayListModel PlayList { get; set; }

        public bool? PlayListHasItems { get { return PlayList?.PlayList?.Any(); } }
        public bool? PlayListHasNoItems { get { return !PlayListHasItems; } }
        public PlayListViewModel(INavigation Navigation) : base(Navigation)
        {
            PlayList = new PlayListModel();

            PlayList = new PlayListService().GetUserPlayList(User).Result;

        }

        public Command<CourseModel> RemoveFromPlaylist
        {
            get
            {
                return new Command<CourseModel>((challenge) =>RemoveCourseFromPlaylist(challenge));
            }
        }

        private void RemoveCourseFromPlaylist(CourseModel course)
        {
            PlayListService.TempPlayList.Remove(course);
            PlayList.PlayList.Remove(course);
        }

      
    }
}
