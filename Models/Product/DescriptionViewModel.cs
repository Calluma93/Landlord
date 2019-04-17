namespace Landlord.Models.Product
{
    public class DescriptionViewModel : ContentViewModel
    {
        public DescriptionViewModel(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}