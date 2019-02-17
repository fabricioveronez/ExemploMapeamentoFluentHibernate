﻿using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class RegionMap : ClassMap<Region>
    {
        public RegionMap()
        {
            Table("Region");
            Id(x => x.RegionID, "[RegionID]").Not.Nullable().Length(4);
            HasMany(x => x.Territories).Table("Territories").KeyColumn("RegionID");
            Map(x => x.RegionDescription, "[RegionDescription]").Not.Nullable().Length(100);
        }
    }
}
