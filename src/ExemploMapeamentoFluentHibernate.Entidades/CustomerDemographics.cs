using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades
{
    public class CustomerDemographics
    {
        public virtual string CustomerTypeID { get; set; }
        public virtual IList<Customers> Customers { get; set; }
        public virtual string CustomerDesc { get; set; }
    }
}
