using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Entities
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public EquipmentType EquipmentType { get; set; }
    }
}
