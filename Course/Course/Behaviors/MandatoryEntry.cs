using Xamarin.Forms;

namespace Course.Behaviors
{
    public class MandatoryEntry : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += BindableTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= BindableTextChanged;
        }
        private void BindableTextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                (sender as Entry).BackgroundColor = Color.Red;
            }
            else
            {
                (sender as Entry).BackgroundColor = Color.Transparent;
                var control = (sender as Entry).FindByName<Label>($"{(sender as Entry).ClassId}Error");
                if (control != null)
                {
                    control.IsVisible = false;
                }
            }
        }
    }
}
