using FluentNHibernate.Mapping;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class CustomerDemographicsMap : ClassMap<CustomerDemographics>
    {
        public CustomerDemographicsMap()
        {
            References(x => x.Customers);
            Map(x => x.CustomerDesc);
        }
    }
}
