using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Models
{
    public class PlayListModel
    {
        public UserModel User { get; set; }
        public List<CourseModel> PlayList { get; set; }
    }
}
