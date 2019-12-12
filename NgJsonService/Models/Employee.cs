using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NgJsonService.Models {

    public class Employee {
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Username { get; set; }
        [StringLength(30)]
        [Required]
        public string Password { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [StringLength(30)]
        [Required]
        public string Address { get; set; }
        [StringLength(30)]
        [Required]
        public string City { get; set; }
        [StringLength(2)]
        [Required]
        public string StateCode { get; set; }
        [StringLength(10)]
        [Required]
        public string Zip { get; set; }
        public bool IsActive { get; set; } = true;
        public int Salary { get; set; } = 50000;
        public int PtoDays { get; set; } = 15;

        public Employee() { }
    }
}
