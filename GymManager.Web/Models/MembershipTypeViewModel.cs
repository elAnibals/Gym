using System.ComponentModel.DataAnnotations;

namespace GymManager.Web.Models
{
    public class MembershipTypeViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public decimal Cost { get; set; }
    }
}
