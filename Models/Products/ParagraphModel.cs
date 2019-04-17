namespace Services.Models.Products
{
    public class ParagraphModel : ContentModel
    {
        public ParagraphModel(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}
