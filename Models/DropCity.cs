﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CascadingDropdown.Models
{
    public class DropCity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
    }
}
