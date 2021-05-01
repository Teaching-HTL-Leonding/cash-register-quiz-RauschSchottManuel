using CashRegister.Shared.DataModel;
using CashRegister.Shared.DTOs;
using CashRegister.WebAPI.EFCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace CashRegister.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptsController : ControllerBase
    {
        private readonly CashRegisterDataContext context;

        public ReceiptsController(CashRegisterDataContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateReceipt([FromBody] ReceiptLineDTO[] receiptLines)
        { 

            if (receiptLines.Length <= 0) return BadRequest();

            var products = new Dictionary<int, Product>();

            foreach(var receiptLine in receiptLines)
            {
                var product = await context.Products.Where(p => p.ID == receiptLine.ProductID).FirstOrDefaultAsync();

                if (product is null) return BadRequest();

                products.Add(product.ID, product);
            }

            // Build receipt from DTO
            
                var newReceipt = new Receipt
            {
                ReceiptTimestamp = DateTime.UtcNow,
                ReceiptLines = receiptLines.Select(rl => new ReceiptLine
                {
                    ID = 0,
                    Product = products[rl.ProductID],
                    Amount = rl.Amount,
                    TotalPrice = rl.Amount * products[rl.ProductID].UnitPrice
                }).ToList()
            };
            newReceipt.TotalPrice = newReceipt.ReceiptLines.Sum(rl => rl.TotalPrice);

            context.Receipts.Add(newReceipt);
            await context.SaveChangesAsync();

            return Created("", newReceipt);
        }
    }
}
