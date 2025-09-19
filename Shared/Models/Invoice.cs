using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace BlazorEntity2025.Shared.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public string CustomerName { get; set; } = string.Empty;

        public List<InvoiceItem> Items { get; set; } = new();
    }

    public class InvoiceItem
    {
        [Key]
        public int ItemID { get; set; }
        public int InvoiceID { get; set; }   
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [JsonIgnore]
        public Invoice? Invoice { get; set; }
    }
}
