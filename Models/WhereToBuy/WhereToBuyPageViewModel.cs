using Landlord.Models.Shared;
using System.Collections.Generic;

namespace Landlord.Models.WhereToBuy
{
    public class WhereToBuyPageViewModel : PageViewModel
    {
        public IEnumerable<RetailerViewModel> Retailers { get; set; }
    }
}