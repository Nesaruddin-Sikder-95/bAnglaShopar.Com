﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bAnglaShoper.ComEntities
{
    public class Category : baseEntity
    {        
        public List<Product> Products { get; set; }
    }
}
