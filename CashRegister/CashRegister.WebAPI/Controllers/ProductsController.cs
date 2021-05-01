using CashRegister.Shared.DataModel;
using CashRegister.WebAPI.EFCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegister.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly CashRegisterDataContext context;

        public ProductsController(CashRegisterDataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts([FromQuery]string? nameFilter = null)
        {
            IQueryable<Product> products = context.Products;

            if (!string.IsNullOrEmpty(nameFilter))
            {
                products = products.Where(p => p.ProductName.Contains(nameFilter));
            }

            return await products.ToListAsync();
        }

    }
}
