using System.Collections.ObjectModel;

namespace Course.Models
{
    public class PlayListModel
    {
        public UserModel User { get; set; }
        public ObservableCollection<CourseModel> PlayList { get; set; }
    }
}
