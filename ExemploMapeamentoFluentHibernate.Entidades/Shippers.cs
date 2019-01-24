using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades
{
    public class Shippers
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public IList<Orders> Orders { get; set; }
        public string Phone { get; set; }
    }
}
