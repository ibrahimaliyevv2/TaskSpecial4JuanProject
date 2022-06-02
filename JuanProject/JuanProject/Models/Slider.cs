﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JuanProject.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string SubTitle { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
    }
}
