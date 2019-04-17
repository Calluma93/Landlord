using Landlord.Models.Shared;
using System.Collections.Generic;

namespace Landlord.Models.Support
{
    public class SupportPageViewModel : PageViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}