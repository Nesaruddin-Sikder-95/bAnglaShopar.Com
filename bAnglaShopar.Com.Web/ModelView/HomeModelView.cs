using bAnglaShoper.ComEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bAnglaShopar.Com.Web.ModelView
{
    public class HomeModelView
    {
        public List<Category> categoris { get; set; }
        public List<Product> products { get; set; }
    }
}