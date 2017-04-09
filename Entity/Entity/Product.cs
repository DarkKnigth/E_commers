using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.Entity
{
      public class Product
    {
          public int ProductID {set;get;}

          public string ProductName { set; get; }

          public decimal ProductPrice { set; get; }

          public int ProductQuantity { set; get; }

          public string ProductPicture { set; get; }

          public bool IsAvilable { set; get; }

          public int CategoryID { set; get; }

          public int SupplerID { set; get; }


          public Product()
          { 
          }



          public Product(int ProductID, string ProductName, decimal PriductPrice, int Quantity, string pic,
              bool IsAvilable,
              int CategoryID,
              int SupplerID
              )

          {
              this.CategoryID = CategoryID;
              this.ProductPicture = pic;
              this.SupplerID = SupplerID;
              this.ProductName = ProductName;
              this.ProductID = ProductID;
              this.ProductPrice = PriductPrice;
              this.IsAvilable = IsAvilable;
              this.ProductQuantity = Quantity;

          }



        public Product( string ProductName, decimal PriductPrice, int Quantity,
           int ProductID,
            int CategoryID,
            int SupplerID
            )

        {
            this.CategoryID = CategoryID;
         
           
            this.SupplerID = SupplerID;
            this.ProductName = ProductName;
            this.ProductID = ProductID;
            this.ProductPrice = PriductPrice;
            this.ProductQuantity = Quantity;

        }







    }
}
