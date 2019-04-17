using System.Collections.Generic;
using Landlord.Models.Shared;

namespace Landlord.Models.Home
{
    public class HomePageViewModel : PageViewModel
    { 
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}