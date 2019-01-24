using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades
{
    public class CustomerDemographics
    {
        public IList<Customers> Customers { get; set; }
        public string CustomerDesc { get; set; }
    }
}
