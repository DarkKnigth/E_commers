using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Ecommers.BL
{

   
    public class Categorycs
    {
        Ecommers.DL.Categorycs DAL = new DL.Categorycs();

        public int Add(Ecommers.Entity.Category catE)
        {
            if (CheckData(catE) == 0)
                return 0;
            else
                return DAL.Add(catE);
        
        }

        public int Edit(Ecommers.Entity.Category catE)
        {
            if (CheckData(catE) == 0)
                return 0;
            else
                return DAL.Edit(catE);

        }

        public int Remove(Ecommers.Entity.Category catE)
        {
            if (catE.SupplierID ==0 && catE.CategoryID==0)
                return 0;
            else
                return DAL.Rmove(catE);

        }


        public DataTable getData(int SupID)
        {
            return DAL.getData(SupID);
        }

        public DataTable getData(string name, int SupID)
        {
            if (name.Length == 0)
                return DAL.getData(SupID);
            else
                return DAL.getData(name.Trim(), SupID);
        }

        public DataTable getData(int IDCAT, int SupID)
        {
            if (IDCAT == 0)
                return DAL.getData(SupID);
            else
                return DAL.getData(IDCAT, SupID);
                   
      }

        private int CheckData(Ecommers.Entity.Category cat)
        {
            if (cat.CategoryID == 0) return 0;
            else if (cat.CategoryName.Length == 0) return 0;
            else if (cat.SupplierID == 0) return 0;
            else
                return 1;

        }

        public int MaxValue(int IdSup)
        {
            return DAL.MaxValue(IdSup);
        }

       }
}
