using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class TerritoriesMap : ClassMap<Territories>
    {
        public TerritoriesMap()
        {
            Id(x => x.TerritoryID);
            Map(x => x.TerritoryDescription);
            References(x => x.Employees);
            HasOne(x => x.Region).PropertyRef(x=>x.Territories);
        }
    }
}
