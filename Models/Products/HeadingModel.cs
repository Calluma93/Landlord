namespace Services.Models.Products
{
    public class HeadingModel : ContentModel
    {
        public HeadingModel(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}