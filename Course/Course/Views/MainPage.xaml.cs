using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Course.Models;

namespace Course.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage :  MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();
        
            MasterBehavior = MasterBehavior.Popover;
            // Navigation.PushModalAsync(new Login());
            //NavigationPage.SetHasNavigationBar(this, false);
            MasterView.NavigationListView.ItemSelected += NavigationListView_ItemSelected;
            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
   
        }

        //public async Task NavigateFromMenu(int id)
        //{
        //    if (!MenuPages.ContainsKey(id))
        //    {
        //        switch (id)
        //        {
        //            case (int)MenuItemType.Browse:
        //                MenuPages.Add(id, new NavigationPage(new CoursesList()));
        //                break;
        //            case (int)MenuItemType.About:
        //                MenuPages.Add(id, new NavigationPage(new AboutPage()));
        //                break;
        //        }
        //    }

        //    var newPage = MenuPages[id];

        //    if (newPage != null && Detail != newPage)
        //    {
        //        Detail = newPage;

        //        if (Device.RuntimePlatform == Device.Android)
        //            await Task.Delay(100);

        //        IsPresented = false;
        //    }
        //}

        private void NavigationListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is MasterNavigationItem item)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Target));
                MasterView.NavigationListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}