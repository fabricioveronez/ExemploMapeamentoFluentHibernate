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
            HasOne(x => x.Supplier).PropertyRef(x => x.Products);
            HasOne(x => x.Category).PropertyRef(x => x.Products);
            Map(x => x.QuantityPerUnit);
            References(x => x.OrdersDetail);
            Map(x => x.UnitPrice);
            Map(x => x.UnitsInStock);
            Map(x => x.UnitsOnOrder);
            Map(x => x.ReorderLevel);
            Map(x => x.Discontinued);
        }
    }
}
