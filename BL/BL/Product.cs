using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Ecommers.Entity;

namespace Ecommers.BL
{
    public class Product :Ecommers.Entity.Aggration
    {
        Ecommers.DL.Product DAL = new Ecommers.DL.Product();

        public int Add(Ecommers.Entity.Product product)
        {
            if (CheckData(product) == 0)
                return 0;
            else
                return DAL.Add(product);

        }

        public int Edit(Ecommers.Entity.Product product)
        {
            if (CheckData(product) == 0)
                return 0;
            else
                return DAL.Edit(product);

        }

        public int Remove(Ecommers.Entity.Product product)
        {
            if (CheckData(product) == 0)
                return 0;
            else
                return DAL.Rmove(product);

        }

        public DataTable getData()
        {
            return DAL.getData();
        
        }


        public DataTable getData(string name)
        {
            if (name.Length == 0)
                return DAL.getData();
            else
               return DAL.getData(name.Trim());

        }


        public DataTable getData(int IDsup)
        {
            if (IDsup==0)
                return DAL.getData();
            else
                return DAL.getData(IDsup);

        }



        private int CheckData(Entity.Product product)
        {
            if (product.ProductID == 0) return 0;
            else if (product.ProductName.Length == 0) return 0;
            else if (product.ProductPrice == 0) return 0;
            else if (product.ProductQuantity == 0) return 0;
           // else if (product.ProductPicture.Length == 0) return 0;
            else if (product.CategoryID == 0) return 0;
            else if (product.SupplerID == 0) return 0;
            else return 1;
        }


        public int MaxValue(int IdSup)
        {
            return DAL.MaxValue(IdSup);
        }

        public int MaxVulae(string Query = "")
        {
            return DAL.MaxVulae(Query);
        }

        public int MinVulae(string Query = "")
        {
            return DAL.MinVulae(Query);
        }

        public int SumVulae(string Query = "")
        {
            return DAL.SumVulae(Query);
        }

        public int AVGVulae(string Query = "")
        {
            return DAL.AVGVulae(Query);
        }

        public int CountVulae(string Query = "")
        {
            return DAL.CountVulae(Query);
        }


    }
}
