using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class ProductsMap : ClassMap<Products>
    {
        public ProductsMap()
        {
            Id(x => x.ProductID);
            Map(x => x.ProductName);
            References(x => x.Supplier, "SupplierID");
            References(x => x.Category, "CategoryID");
            Map(x => x.QuantityPerUnit);
            HasMany(x => x.OrdersDetail).Table("OrderDetails").KeyColumn("ProductID");
            Map(x => x.UnitPrice);
            Map(x => x.UnitsInStock);
            Map(x => x.UnitsOnOrder);
            Map(x => x.ReorderLevel);
            Map(x => x.Discontinued);
        }
    }
}
