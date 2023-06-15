using GymManager.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GymManager.Web.Models
{
    public class MemberViewModel
    {
        public int Id { get; set; }

        [StringLength(30)]
        [Required /*(ErrorMessage ="Debe ingresar su nombre")*/]
        public string Name { get; set; }
        [StringLength(30)]
        [Required]
        public string LastName { get; set; }
        [Required]
        [BindProperty, DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
        public int CityId { get; set; }
        [EmailAddress]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }
        public bool AllowNewsLetter { get; set; }
        public List<City> Cities { get; set; }
        public int MembershipTypeId { get; set; }


    }
}
