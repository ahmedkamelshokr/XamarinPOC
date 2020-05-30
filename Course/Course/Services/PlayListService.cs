using Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Services
{
    public class PlayListService
    {
     
        public PlayListService()
        {
           
        }
    public    async Task<PlayListModel> GetUserPlayList(UserModel user)
        {
            return await Task.FromResult( new PlayListModel
            {
                User = user,
                PlayList =new MockCourseModelStore().GetItemsAsync().Result.ToList()
            }
            );
        }
    }
}

