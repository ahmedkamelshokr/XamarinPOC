using Course.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Course.TemplateSelectors
{
    public class CourseTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RatedTemplate { get; set; }
        public DataTemplate RegularTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return (item as CourseModel).RateCount > 85 ?
                 RatedTemplate : RegularTemplate;


        }
    }
}
