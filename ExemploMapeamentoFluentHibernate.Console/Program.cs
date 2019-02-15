using ExemploMapeamentoFluentHibernate.Entidades;
using ExemploMapeamentoFluentHibernate.Entidades.Mapeamento;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Data.SqlClient;
using System.Linq;

namespace ExemploMapeamentoFluentHibernate.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            var sessionFactory = Fluently.Configure()
                  .Database(MsSqlConfiguration.MsSql2012.ConnectionString("Data Source=localhost;Initial Catalog=Northwind;User ID=sa;Password=Northwing0123"))
                  .Mappings(m =>
                    m.FluentMappings
                      .AddFromAssemblyOf<EmployeesMap>())
                  .BuildSessionFactory();

            using (var nh = sessionFactory.OpenSession())
            {
                var r = nh.Load<Employees>(2);
            }
        }
    }
}
