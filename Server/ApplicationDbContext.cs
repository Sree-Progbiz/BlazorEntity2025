using BlazorEntity2025.Shared;
using BlazorEntity2025.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorEntity2025.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
    }
}
