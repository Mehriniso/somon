using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMON.DAL
{
    public class Tasks
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string TaskName { get; set; }
        public string Explanation { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [Required]
        public Category Category { get; set; }
    }
}
