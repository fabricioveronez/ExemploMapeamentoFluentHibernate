using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades
{
    public class OrderDetails
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnityPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
    }
}
