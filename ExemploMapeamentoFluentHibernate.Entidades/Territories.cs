using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades
{
    public class Territories
    {
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public IList<Employees> Employees { get; set; }
        public Region Region { get; set; }
    }
}
