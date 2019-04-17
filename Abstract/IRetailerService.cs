using Services.Models.Retailer;
using System.Collections.Generic;

namespace Services.Abstract
{
    public interface IRetailerService
    {
        IEnumerable<RetailerModel> GetRetailers();
    }
}
