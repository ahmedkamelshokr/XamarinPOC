using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

using Course.Models;

namespace Course.Views
{
  
    [DesignTimeVisible(false)]
    public partial class MainPage :  MasterDetailPage
    {
     
        public MainPage()
        {
            InitializeComponent();
        
            MasterBehavior = MasterBehavior.Popover;
            MasterView.NavigationListView.ItemSelected += NavigationListView_ItemSelected;
        }

      

        private void NavigationListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is MasterNavigationItem item)
            {
                switch (item.PageName)
                {
                    case "CoursesList":
                        Detail = new NavigationPage(new CoursesList());
                        break;
                    case "PlayListView":
                        Detail = new NavigationPage(new PlayListView()) ;
                        break;
                    case "AboutPage":
                        Detail = new NavigationPage(new AboutPage());
                        break;
                   
                }
              
                MasterView.NavigationListView.SelectedItem = null;
                IsPresented = false;
            }

                       

        }
    }
}