using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class ShippersMap : ClassMap<Shippers>
    {
        public ShippersMap()
        {
            Id(x => x.ShipperID);
            Map(x => x.CompanyName);
            HasMany(x => x.Orders).Table("Orders").KeyColumn("ShipperID");
            Map(x => x.Phone);
        }
    }
}
