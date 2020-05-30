using Course.Models;
using Course.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Course.ViewModels
{
    public class PlayListViewModel : BaseViewModel
    {
        public UserModel User { get; set; }
        public PlayListModel PlayList { get; set; }
        public PlayListViewModel(INavigation Navigation) : base(Navigation)
        {
            PlayList = new PlayListModel();

            PlayList = new PlayListService().GetUserPlayList(User).Result;

        }
    }
}
