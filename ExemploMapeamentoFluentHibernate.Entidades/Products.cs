using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploMapeamentoFluentHibernate.Entidades
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Suppliers Supplier { get; set; }
        public Categories Category { get; set; }
        public string QuantityPerUnit { get; set; }
        public IList<OrderDetails> OrdersDetail { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
