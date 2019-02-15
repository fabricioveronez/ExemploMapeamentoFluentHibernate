using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades
{
    public class Region
    {
        public virtual int RegionID { get; set; }
        public virtual IList<Territories> Territories { get; set; }
        public virtual string RegionDescription { get; set; }
    }
}
