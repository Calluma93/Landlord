using Services.Models.Shared;
using System.Collections.Generic;

namespace Services.Models.PageContent
{
    public class DownloadLinksModel
    {
        public DownloadLinksModel(IEnumerable<DownloadLinkModel> downloadLinks)
        {
            DownloadLinks = downloadLinks;
        }

        public IEnumerable<DownloadLinkModel> DownloadLinks { get; private set; }
    }
}
