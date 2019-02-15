using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class RegionMap : ClassMap<Region>
    {
        public RegionMap()
        {
            Id(x => x.RegionID);
            HasMany(x => x.Territories).Table("Territories").KeyColumn("RegionID");
            Map(x => x.RegionDescription);
        }
    }
}
