using FluentNHibernate.Mapping;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class OrderDetailsMap : ClassMap<OrderDetails>
    {
        public OrderDetailsMap()
        {
           
            Id(x => x.OrderID);
            Id(x => x.ProductID);
            References(x => x.Order, "OrderID");
            References(x => x.Product, "ProductID");
            Map(x => x.UnitPrice);
            Map(x => x.Quantity);
            Map(x => x.Discount);
        }
    }
}
