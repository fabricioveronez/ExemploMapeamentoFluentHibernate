using FluentNHibernate.Mapping;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class OrderDetailsMap : ClassMap<OrderDetails>
    {
        public OrderDetailsMap()
        {
            Id(x => x.OrderID);
            HasOne(x => x.Product).PropertyRef(x => x.OrdersDetail);
            Map(x => x.UnityPrice);
            Map(x => x.Quantity);
            Map(x => x.Discount);
        }
    }
}
