﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMON.DAL
{
   public  class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public ICollection<Tasks> Tasks { get; set; }
    }
}
