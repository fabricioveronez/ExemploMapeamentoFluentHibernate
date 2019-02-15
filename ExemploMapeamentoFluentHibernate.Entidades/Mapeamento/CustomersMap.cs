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
            HasManyToMany(x => x.CustomerDemographics).Table("CustomerCustomerDemo").ParentKeyColumn("CustomerID").ChildKeyColumn("CustomerTypeID");
            HasMany(x => x.Orders).Table("Orders").KeyColumn("CustomerID");
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
