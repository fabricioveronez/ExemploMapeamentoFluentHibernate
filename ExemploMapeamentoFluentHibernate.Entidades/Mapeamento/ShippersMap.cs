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
            References(x => x.Orders);
            Map(x => x.Phone);
        }
    }
}
