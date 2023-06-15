using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Entities
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        public bool IsClosed { get; set; }
        public Member Member { get; set; }

        public List<ProductSale> ProductSales { get; set; }

        public List<MembershipSale> MembershipSales { get; set; }

        public Sale() 
        {
            ProductSales = new List<ProductSale>();
            MembershipSales = new List<MembershipSale>();

        }
        
    }
}
