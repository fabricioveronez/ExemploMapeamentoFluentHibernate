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
            HasManyToMany(x => x.Employees).Table("EmployeeTerritories").ParentKeyColumn("TerritoryID").ChildKeyColumn("EmployeeID");
            References(x => x.Region, "RegionID");
        }
    }
}
