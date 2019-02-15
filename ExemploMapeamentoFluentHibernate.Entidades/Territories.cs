using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades
{
    public class Territories
    {
        public virtual string TerritoryID { get; set; }
        public virtual string TerritoryDescription { get; set; }
        public virtual IList<Employees> Employees { get; set; }
        public virtual Region Region { get; set; }
    }
}
