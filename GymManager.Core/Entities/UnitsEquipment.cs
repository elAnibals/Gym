using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Entities
{
    public class UnitsEquipment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Stock { get; set; }
        public Equipment Equipment { get; set; }
        public City City { get; set; }
        
    }
}
