using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Entities
{
    public class MembershipType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public decimal Cost { get; set; }


        [Required]
        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }
        
        public List<Member> Members { get; set; }

        public List<MembershipSale> MembershipSales { get; set; }

        public MembershipType() 
        { 
            Members = new List<Member>();
            MembershipSales = new List<MembershipSale>();
        }
    }
}
