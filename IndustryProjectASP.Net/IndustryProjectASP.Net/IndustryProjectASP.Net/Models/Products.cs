using IndustryProjectASP.Net.Areas.Identity.Data;
using IndustryProjectASP.Net.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IndustryProjectASP.Net.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}


