using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bAnglaShoper.ComEntities
{
    public class Product : baseEntity
    {
        public virtual Category Category { get; set; }
        //public int CategoryID { get; set; }
        public decimal Price { get; set; }
    }
}
