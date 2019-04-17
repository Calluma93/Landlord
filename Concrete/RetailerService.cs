using Services.Models.Shared;
using Services.Abstract;
using Services.Models.Retailer;
using System.Collections.Generic;

namespace Services.Concrete
{
    public class RetailerService : IRetailerService
    {
        private static readonly RetailerModel[] retailers =
            new RetailerModel[]
            {
                new RetailerModel("https://www.andertons.co.uk/landlord-fx", new ImageModel("Andertons", "Retailer/where-to-buy-andertons.jpg")),
                new RetailerModel("https://www.guitarguitar.co.uk/landlord-fx", new ImageModel("guitarguitar", "Retailer/where-to-buy-guitar.jpg")),
                new RetailerModel("https://www.pmtonline.co.uk/brands/landlord-fx", new ImageModel("PMT", "Retailer/where-to-buy-pmt.jpg"))
            }
        ;

        public IEnumerable<RetailerModel> GetRetailers()
        {
            return retailers;
        }
    }
}
