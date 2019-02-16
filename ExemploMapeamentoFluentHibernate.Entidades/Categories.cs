using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades
{
    public class Categories
    {
        public virtual int CategoryID { get; set; }
        public virtual IList<Products> Products { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual string Description { get; set; }
        public virtual byte[] Picture { get; set; }
    }
}
