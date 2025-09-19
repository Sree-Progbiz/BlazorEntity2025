using BlazorEntity2025.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorEntity2025.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public InvoiceController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Invoice>>> Get()
        //{
        //    return await context.Invoices.ToListAsync();
        //}
        [HttpGet("get-invoice")]
        public async Task<ActionResult<List<Invoice>>> GetInvoices()
        {
            var invoices = await context.Invoices
                                    .Include(i => i.Items)
                                    .ToListAsync();
            return Ok(invoices);
        }

    }

}
