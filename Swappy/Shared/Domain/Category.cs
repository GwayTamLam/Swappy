﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappy.Shared.Domain
{
    public class Category : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
