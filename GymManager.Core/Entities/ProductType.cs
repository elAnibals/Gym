using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Entities
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        
        public List<MesureType> Mesures { get; set; }

        public ProductType()
        {
            Mesures = new List<MesureType>();
        }

        
    }
}
