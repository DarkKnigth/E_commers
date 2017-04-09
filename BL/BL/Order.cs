using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Ecommers.BL
{
    public class Order
    {
        Ecommers.DL.Order DAL = new DL.Order();
        public int Add(Ecommers.Entity.Order order)
        {
            if (CheckData(order) == 0)
                return 0;
            else
                return DAL.Add(order);

        }

        public int Edit(Ecommers.Entity.Order order)
        {
            if (CheckData(order) == 0)
                return 0;
            else
                return DAL.Edit(order);

        }


        public int Remove(Ecommers.Entity.Order order)
        {
            if (CheckData(order) == 0)
                return 0;
            else
                return DAL.Remove(order);

        }


        public  DataTable getData()
        {
            return DAL.getData();
        }

        public  DataTable getData(int ID)
        {
            if (ID == 0)
                return DAL.getData();
            else
                return DAL.getData(ID);

        }


        public DataTable getData2(int ID)
        {
            return DAL.getData2(ID);
        }
        public int update(int ID, double totle)
        {
            return DAL.updatetotle(ID, totle);
        }


        private int CheckData(Ecommers.Entity.Order order)
        {
            
            if (order.OrderTotal == 0) return 0;
            else if (order.CustomerID == 0) return 0;
            else if (order.SupplierID == 0) return 0;
            else
                return 1;
        }


    }
}
