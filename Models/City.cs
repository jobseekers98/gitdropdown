﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CascadingDropdown.Models
{
    public class City
    {
        [Key]
        public int MyProperty { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public State State { get; set; }
    }

}
