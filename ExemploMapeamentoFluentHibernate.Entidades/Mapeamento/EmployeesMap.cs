using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades.Mapeamento
{
    public class EmployeesMap : ClassMap<Employees>
    {
        public EmployeesMap()
        {
            Id(x => x.EmployeeID);
            Map(x => x.LastName);
            Map(x => x.FirstName);
            Map(x => x.Title);
            Map(x => x.TitleOfCourtesy);
            Map(x => x.BirthDate);
            References(x => x.Territories);
            Map(x => x.HireDate);
            Map(x => x.Address);
            Map(x => x.City);
            Map(x => x.Region);
            Map(x => x.PostalCode);
            Map(x => x.Country);
            Map(x => x.HomePhone);
            Map(x => x.Extension);
            Map(x => x.Photo);
            Map(x => x.Notes);
            References(x => x.Orders);
            HasOne(x => x.Supervisor).PropertyRef(x => x.Subordinados);
            Map(x => x.PhotoPath);
        }
    }
}
