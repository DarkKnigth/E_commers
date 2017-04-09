using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.Entity
{
   public  class Order
    {
       public int OrderID { set;get;}
       public double OrderTotal { set;get;}
       public int SupplierID { set; get; }
       public int CustomerID { set; get; }
       
        public DateTime OrderData { set; get; }

       public Order()
       { 
       
       }

       public Order(int orderId, double Total, DateTime Date, int SupplierID,int CustomerID) 
       {
           this.CustomerID = CustomerID;
           this.OrderID = orderId;
           this.SupplierID = SupplierID;
           this.OrderTotal = Total;
       
       }





    }
}
