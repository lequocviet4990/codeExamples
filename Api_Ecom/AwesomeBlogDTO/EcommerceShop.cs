using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeBlogDTO
{
    public class EcommerceShop
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

       
        [StringLength(4000)]
        public string Body { get; set; }

        public bool Enable { get; set; }

        public EcommerceShop()
        {
            Enable = true;
        }

    }
}
