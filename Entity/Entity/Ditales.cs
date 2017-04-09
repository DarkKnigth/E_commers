using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.Entity
{
    public class Ditales
    {
        public int ProductID{set;get;}
        public decimal ProductPrice { set; get; }
        public int ProductQunity { set; get; }
        public int ProductTotal { set; get; }
        public int SupplierID { set; get; }
        public int OrderID { set; get; }
        public int CustomerID { set; get; }

        public Ditales()
        { 
        
       }
        public Ditales(int ProductID, decimal ProductPrice, int ProductQunity,
           int SupplierID, int OrderID, int CustomerID)
        {
            this.CustomerID = CustomerID;
            this.OrderID = OrderID;
            this.ProductID = ProductID;
            this.ProductPrice = ProductPrice;
            this.ProductQunity = ProductQunity;
            this.SupplierID = SupplierID;

        }


    }
}
