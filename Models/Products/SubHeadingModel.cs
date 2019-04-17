namespace Services.Models.Products
{
    public class SubHeadingModel : ContentModel
    {
        public SubHeadingModel(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}
