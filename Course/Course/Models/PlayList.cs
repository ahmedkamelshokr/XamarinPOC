using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Course.Models
{
    public class PlayListModel
    {
        public UserModel User { get; set; }
        public ObservableCollection<CourseModel> PlayList { get; set; }
    }
}
