using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Entities
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        [Required /*(ErrorMessage ="Debe ingresar su nombre")*/]
        public string Name { get; set; }

        [StringLength(30)]
        [Required]
        public string LastName { get; set; }

        [Required]
        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        public City City { get; set; }

        [EmailAddress]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [Required]
        public bool AllowNewsLetter { get; set; }

        [Required]
        public bool isActive { get; set; }

        [Required]
        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ActivationDate { get; set; }


        public MembershipType MembershipType { get; set; }

        public List<Sale> Sales { get; set; }


        public Member()
        {
            Sales = new List<Sale>();
        }

        
    }
}
