﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Entities
{
    public class Role
    {
        [Key]
        public string Name { get; set; }
    }
}
