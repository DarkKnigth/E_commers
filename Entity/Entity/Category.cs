using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.Entity
{
    
   public    class Category
    {
       public int CategoryID { set; get; }
       public string CategoryName { set; get; }
       public int SupplierID { set; get; }

        public Category(int CategoryID, string CategoryName, int SupplierID)
        {

            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.SupplierID = SupplierID;
        }

        public Category()
        { 
        }
        
        
    }
}
