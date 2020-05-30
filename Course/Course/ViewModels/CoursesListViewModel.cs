using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Course.Models;
using Course.Views;
using System.Linq;

namespace Course.ViewModels
{
    public class CoursesListViewModel : BaseViewModel
    {
        public ObservableCollection<CourseModel> Courses { get; set; }
        public Command LoadItemsCommand { get; set; }
        public string SearchPararmeter { get; set; }
        public CourseModel SelectedCourse { get; set; }
        public Command CourseSelectedCommand { get; set; }
        public Command SearchCoursesCommand { get; set; }
        public CoursesListViewModel(INavigation Navigation) : base(Navigation)
        {

            Courses = new ObservableCollection<CourseModel>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            CourseSelectedCommand = new Command(async () => await SelectedItemChanged());
            SearchCoursesCommand = new Command(async () => await ExecuteLoadItemsCommand());
            //MessagingCenter.Subscribe<CourseDetails, CourseModel>(this, "CourseSaved", async (obj, item) =>
            //{
            //    var newItem = item as CourseModel;
            //    Courses.Add(newItem);
            //    await CourseDataStore.AddItemAsync(newItem);
            //});
        }


        async Task SelectedItemChanged()
        {

            await Navigation.PushAsync(new CourseDetails(SelectedCourse));

        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Courses.Clear();
                var items = await CourseDataStore.GetItemsAsync(true);
              
                if (!string.IsNullOrWhiteSpace(SearchPararmeter))
                    items = items.Where(c => c.Name.ToLower().Contains(SearchPararmeter.ToLower()));

                foreach (var item in items)
                {
                    Courses.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}