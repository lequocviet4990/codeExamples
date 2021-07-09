using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeBlogDTO
{
    public class EcommerceShopLink
    {
        public string Id { get; set; } // GUID

        public string ProductId { get; set; } // GUID

        [Required]
        public int EcommerceShopID { get; set; } 

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public virtual string Url { get; set; }

        public bool Enable { get; set; }

        public EcommerceShopLink()
        {
            Enable = true;
        }
    }
}