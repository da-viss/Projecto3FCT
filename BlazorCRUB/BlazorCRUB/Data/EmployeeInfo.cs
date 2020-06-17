using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUB.Data
{
    public class EmployeeInfo
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public int Name { get; set; }

        [Required]
        public int City { get; set; }

        [Required]
        public int Country { get; set; }

        [Required]
        public int Gender { get; set; }
    }
}
