using FluentNHibernate.Mapping;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class CustomerDemographicsMap : ClassMap<CustomerDemographics>
    {
        public CustomerDemographicsMap()
        {
            Id(x => x.CustomerTypeID);
            HasManyToMany(x => x.Customers).Table("CustomerCustomerDemo").ParentKeyColumn("CustomerID").ChildKeyColumn("CustomerTypeID").Inverse();
            Map(x => x.CustomerDesc);
        }
    }
}
