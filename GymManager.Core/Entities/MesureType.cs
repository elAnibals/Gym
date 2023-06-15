using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Entities
{
    public class MesureType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(2)]
        public string Size { get; set; }

        [Required]
        public decimal Cost { get; set; }

        public ProductType ProductType { get; set; }

        public List<Inventory> inventories { get; set; }

        public List<ProductSale> sales { get; set; }
        public MesureType() 
        {
            inventories = new List<Inventory>();
            sales = new List<ProductSale>();
        }
    }
}
