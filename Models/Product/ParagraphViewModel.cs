namespace Landlord.Models.Product
{
    public class ParagraphViewModel : ContentViewModel
    {
        public ParagraphViewModel(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}