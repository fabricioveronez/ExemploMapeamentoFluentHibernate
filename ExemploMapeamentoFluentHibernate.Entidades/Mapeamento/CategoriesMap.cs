using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class CategoriesMap : ClassMap<Categories>
    {
        public CategoriesMap()
        {
            Id(x => x.CategoryID).GeneratedBy.Identity();
            HasMany(x => x.Products).Table("Products").KeyColumn("CategoryID");
            Map(x => x.CategoryName);
            Map(x => x.Description);
            Map(x => x.Picture);
        }
    }
}
