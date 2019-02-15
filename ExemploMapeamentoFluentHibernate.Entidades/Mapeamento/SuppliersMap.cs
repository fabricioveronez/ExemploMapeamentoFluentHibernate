using FluentNHibernate.Mapping;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class SuppliersMap : ClassMap<Suppliers>
    {
        public SuppliersMap()
        {
            Id(x => x.SupplierID);
            Map(x => x.CompanyName);
            Map(x => x.ContactName);
            Map(x => x.ContactTitle);
            Map(x => x.Address);
            Map(x => x.City);
            Map(x => x.Region);
            Map(x => x.PostalCode);
            HasMany(x => x.Products).Table("Products").KeyColumn("SupplierID");
            Map(x => x.Country);
            Map(x => x.Phone);
            Map(x => x.Fax);
            Map(x => x.HomePage);
        }
    }
}
