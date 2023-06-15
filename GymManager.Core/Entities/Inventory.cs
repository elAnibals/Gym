using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Entities
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        public MesureType MesureType { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public int NumSales { get; set; }

        [Required]
        public int NumOpenSales { get; set; }
    }
}
