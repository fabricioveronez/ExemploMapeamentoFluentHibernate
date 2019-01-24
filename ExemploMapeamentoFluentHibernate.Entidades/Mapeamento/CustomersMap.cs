using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class CustomersMap : ClassMap<Customers>
    {
        public CustomersMap()
        {
            Id(x => x.CustomerID);
            Map(x => x.CompanyName);
            Map(x => x.ContactName);
            Map(x => x.ContactTitle);
            References(x => x.CustomerDemographics);
            Map(x => x.Address);
            Map(x => x.City);
            Map(x => x.Region);
            Map(x => x.PostalCode);
            Map(x => x.Country);
            Map(x => x.Phone);
            Map(x => x.Fax);
        }
    }
}
