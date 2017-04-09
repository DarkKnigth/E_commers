using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Ecommers.BL
{
    public class Ditales
    {
        Ecommers.DL.Ditales DAL = new DL.Ditales();
        public int Add(Ecommers.Entity.Ditales Ditales)
        {
            if (CheckData(Ditales) == 0)
                return 0;
            else return DAL.Add(Ditales);
            
        }

        public int Edit(Ecommers.Entity.Ditales Ditales)
        {
            if (CheckData(Ditales) == 0)
                return 0;
            else return DAL.Edit(Ditales);

        }

        public int Remove(Ecommers.Entity.Ditales Ditales)
        {
            if (CheckData(Ditales) == 0)
                return 0;
            else return DAL.Remove(Ditales);

        }


        public DataTable getData()
        {
            return DAL.getData();
        }
        public DataTable getData(int ID)
        {
            if (ID == 0)
                return DAL.getData();
            else
            return DAL.getData();
        }

        public int MaxValue(int IDCus)
        {
            return DAL.MaxValue(IDCus);
        }

        public DataTable getData2(int ID,int Cus)
        {
            return DAL.getData2(ID, Cus);
        }




        public int CheckData(Ecommers.Entity.Ditales Ditales)
        {
            if (Ditales.ProductID.ToString().Length == 0) return 0;
            else if (Ditales.ProductPrice.ToString().Length == 0) return 0;
            else if (Ditales.ProductQunity.ToString().Length == 0) return 0;
            else if (Ditales.SupplierID == 0) return 0;
            else if (Ditales.CustomerID == 0) return 0;
            else return 1; 

        }

    }
}
