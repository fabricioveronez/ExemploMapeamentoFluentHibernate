using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class SuppliersMap : ClassMap<Suppliers>
    {
        public SuppliersMap()
        {
            Id(x => x.SupplierID);
            Map(x => x.CompanyName);
            Map(x => x.ContactName);
            Map(x => x.ContactTitle);
            Map(x => x.Address);
            Map(x => x.City);
            Map(x => x.Region);
            Map(x => x.PostalCode);
            References(x => x.Products);
            Map(x => x.Country);
            Map(x => x.Phone);
            Map(x => x.Fax);
            Map(x => x.HomePage);
        }
    }
}
