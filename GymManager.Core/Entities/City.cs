using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        [Required]
        public string Name { get; set; }

        public List<Member> Members { get; set; }
        public List<UnitsEquipment> UnitsEquipment { get; set; }


        public City() 
        {
            UnitsEquipment = new List<UnitsEquipment>();
            Members = new List<Member>();
        }
    }
}
