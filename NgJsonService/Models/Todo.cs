using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NgJsonService.Models {

    public class Todo {
        public int Id { get; set; }
        [StringLength(255)]
        [Required]
        public string Description { get; set; }
        public int Priority { get; set; }
        public DateTime DueDate { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public Todo() {}
    }
}
