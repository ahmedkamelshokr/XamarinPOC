using Course.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Course.Services
{
    public class PlayListService
    {
        public static ObservableCollection<CourseModel> TempPlayList { get; set; }
         static PlayListService()
        {
            TempPlayList = new ObservableCollection<CourseModel>();
        }
        public async Task<PlayListModel> GetUserPlayList(UserModel user)
        {
            return await Task.FromResult(new PlayListModel
            {
                User = user,
                PlayList = TempPlayList
            }
            );
        }
    }
}

