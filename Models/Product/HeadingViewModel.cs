namespace Landlord.Models.Product
{
    public class HeadingViewModel : ContentViewModel
    {
        public HeadingViewModel(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}