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
            References(x => x.Customer).Column("CustomerID");
            References(x => x.Employee).Column("EmployeeID");
            Map(x => x.OrderDate);
            Map(x => x.RequiredDate);
            Map(x => x.ShippedDate);
            References(x => x.Shipper, "ShipVia");
            HasMany(x => x.OrderDetails).Table("OrderDetails").KeyColumn("OrderID");
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
