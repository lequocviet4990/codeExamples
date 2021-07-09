using AwesomeBlogBackEnd.Models;
using AwesomeBlogDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeBlogBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EcomController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EcomController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EcommerceShop
        [HttpGet]
        public async Task<ActionResult<List<EcommerceShop>>> GetEcommerceShop()
        {
            return await _context.EcommerceShops.AsNoTracking().ToListAsync();
        }

        // GET: api/EcommerceShopLink
      
        [HttpPost("GetEcommerceShopLink")]
        public async Task<ActionResult<List<EcommerceShopLink>>> GetEcommerceShopLink(EcommerceShopLinkDTO model)
        {
            return await _context.EcommerceShopLinks.Where(t => t.ProductId == model.ProductID).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<List<EcommerceShopLink>>> AddLink(EcommerceShopLinkDTO model)
        {
            var oldDataLst = await _context.EcommerceShopLinks.Where(t => t.ProductId == model.ProductID).ToListAsync();

            if (oldDataLst != null && oldDataLst.Count > 0)
            {
                _context.EcommerceShopLinks.RemoveRange(oldDataLst);
            }

            List<EcommerceShopLink> lstInsert = new List<EcommerceShopLink>();

            if (model.lstEcomLink != null && model.lstEcomLink.Count > 0)
            {
                foreach (var item in model.lstEcomLink)
                {
                    lstInsert.Add(
                        new EcommerceShopLink
                        {
                            Id = Guid.NewGuid().ToString(),
                            ProductId = model.ProductID,
                            Name = item.Name,
                            Url = item.Url,
                            Enable = item.Enable,
                            EcommerceShopID = item.EcommerceShopID,

                        }
                     );
                }

                _context.EcommerceShopLinks.AddRange(lstInsert);
                await _context.SaveChangesAsync();
            }

            return lstInsert;
        }
    }
}