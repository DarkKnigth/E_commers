using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommers.Entity;
using System.Data;

namespace Ecommers.BL  
{
   public class Users 
    {

        Ecommers.DL.User DAL = new Ecommers.DL.User();
        public int Add(Ecommers.Entity.Users user)
        {
            if (CheckData(user) == 0)

                return 0;
            else
                return DAL.Add(user);
        }



        public int Edit(Ecommers.Entity.Users user)
        {
            if (CheckData(user) == 0)
                return 0;
            else
                return DAL.Edit(user);

        }

        public int Rmovet(Ecommers.Entity.Users user)
        {
            if (user.UserID == 0)
                return 0;
            else
                return DAL.Remove(user);

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
                return DAL.getData(ID);

        }

        public DataTable getData(string name)
        {
            if (name.Length== 0)
                return DAL.getData();
            else
                return DAL.getData(name.Trim());

        }

        public int MaxValue(string Query = "")
        {
            return DAL.MaxValue(Query);
         
        }

        public int MinValue(string Query = "")
        {
            return DAL.MinValue(Query);

        }

        public int SumValue(string Query = "")
        {
            return DAL.SumValue(Query);
        }

        public int AVGValue(string Query = "")
        {
            return DAL.AVGValue(Query);

        }

        public int CountValue(string Query = "")
        {
            return DAL.CountValue(Query);
        }







        private int CheckData(Entity.Users user)
        {
            if (user.Fullname.Length == 0) return 0;
            else if (user.Username.Length == 0) return 0;
            else if (user.Password.Length == 0) return 0;
            else if (user.Phone.Length == 0) return 0;
            else if (user.Address.Length == 0) return 0;
            else if (user.Email.Length == 0) return 0;
            else if (user.Gender.Length == 0) return 0;
           
            else
                return 1;            
        }

        public DataTable CheckUser(string name, string Password)
        {
            
            return DAL.CheckUser(name,Password);
        }

        public int Edit2(Ecommers.Entity.Users users)
        {
            if (users.Fullname.Length == 0) return 0;
            else if (users.Username.Length == 0) return 0;
            else if (users.Password.Length == 0) return 0;
            else if (users.Phone.Length == 0) return 0;
            else if (users.Address.Length == 0) return 0;
            else if (users.Email.Length == 0) return 0;

            else return DAL.Edit2(users);

        }

        public DataTable supp()
        {
            return DAL.Supp();
        }

     
    }
}
