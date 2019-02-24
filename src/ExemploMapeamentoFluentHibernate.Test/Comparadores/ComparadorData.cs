using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Test.Comparadores
{
    public class ComparadorData : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            if (x is DateTime && y is DateTime)
            {
                return x.ToString().Equals(y.ToString());
            }
            else 
            {
                return x.Equals(y);
            }
        }

        public int GetHashCode(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
