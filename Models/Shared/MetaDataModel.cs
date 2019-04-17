namespace Services.Models.Shared
{
    public class MetaDataModel
    {
        public MetaDataModel(string title, string metaDescription)
        {
            Title = title;
            MetaDescription = metaDescription;
        }

        public string Title { get; private set; }

        public string MetaDescription { get; private set; }
    }
}
