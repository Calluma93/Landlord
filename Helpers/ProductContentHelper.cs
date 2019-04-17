using Services.Models.Products;
using Landlord.Models.Product;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Landlord.Helpers
{
    public static class ProductContentHelper
    {
        private static ContentViewModel mapContentToViewModel(ContentModel productContent)
        {
            if(productContent is HeadingModel)
            {
                HeadingModel heading = (HeadingModel)productContent;
                return new HeadingViewModel((heading).Text);
            }
            if (productContent is DescriptionModel)
            {
                DescriptionModel description = (DescriptionModel)productContent;
                return new DescriptionViewModel((description).Text);
            }
            if (productContent is SubHeadingModel)
            {
                SubHeadingModel subHeading = (SubHeadingModel)productContent;
                return new SubHeadingViewModel((subHeading).Text);
            }
            if (productContent is ParagraphModel)
            {
                ParagraphModel paragraph = (ParagraphModel)productContent;
                return new ParagraphViewModel((paragraph).Text);
            }
            throw new Exception("Unknown ContentModel type");
        }

        public static IEnumerable<ContentViewModel> MapContentToViewModel(IEnumerable<ContentModel> productContents)
        {
            return productContents.Select(a => mapContentToViewModel(a));
        }
    }
}