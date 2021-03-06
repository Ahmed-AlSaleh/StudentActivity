﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentActivity.Models
{
    public class Club
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Club Name")]
        public string Name { get; set; }

        
        public Student CoordinatorName { get; set; }
        
        [Required]
        public String StudentId { get; set; }

        public ICollection<Program> Programs { get; set; }
    }
}