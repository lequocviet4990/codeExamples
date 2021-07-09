using AwesomeBlogDTO;
using System.Collections.Generic;

namespace AwesomeBlogBackEnd.Controllers
{
    public class EcommerceShopLinkDTO
    {
        public  List<EcommerceShopLink> lstEcomLink { get; set; }
        public string ProductID { get; set; }
    }
}