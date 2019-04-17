namespace Services.Models.Products
{
    public class DescriptionModel : ContentModel
    {
        public DescriptionModel(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}
