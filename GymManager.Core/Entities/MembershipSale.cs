using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Entities
{
    public class MembershipSale
    {
        [Key]
        public int Id { get; set; }
        public MembershipType MembershipType { get; set; }

        public Sale Sale { get; set; }
    }
}
