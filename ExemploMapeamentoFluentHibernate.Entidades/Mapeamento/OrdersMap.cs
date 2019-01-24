using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class OrdersMap : ClassMap<Orders>
    {
        public OrdersMap()
        {
            Id(x => x.OrderID);
            HasOne(x => x.Customer).PropertyRef(x=>x.Orders);
            HasOne(x => x.Employee).PropertyRef(x => x.Orders);
            Map(x => x.OrderDate);
            Map(x => x.RequiredDate);
            Map(x => x.ShippedDate);
            HasOne(x => x.Shipper).PropertyRef(x=>x.Orders);
            References(x => x.OrderDetails);
            Map(x => x.Freight);
            Map(x => x.ShipName);
            Map(x => x.ShipAddress);
            Map(x => x.ShipCity);
            Map(x => x.ShipRegion);
            Map(x => x.ShipPostalCode);
            Map(x => x.ShipCountry);
        }
    }
}
