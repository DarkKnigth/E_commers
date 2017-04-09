using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.Entity
{
    public class Users
    {

        public int UserID { set; get; }
        public string Fullname { set; get; }

        public string Username { set; get; }

        public string Password { set; get; }

        public string Phone { set; get; }

        public string Address { set; get; }

        public bool Isblock { set; get; }

        public string Email { set; get; }

        public string Gender { set; get; }
        public int Type { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime CreatedTime { set; get; }




        //public Users(int UserID, string Fullnam, string Username, string Phone, string Adrees, bool Isblock, string Email, string Gender, int type)
        //{
        //    this.UserID = UserID;
        //    this.Address = Adrees;
        //    this.Email = Email;
        //    this.Fullname = Fullname;
        //    this.Gender = Gender;
        //    this.Isblock = Isblock;
        //    this.Password = Password;
        //    this.Username = Username;
        //    this.Type = type;
        //}

        //public Users(int UserID, string Fullnam, string Username, string Phone, string Adrees, bool Isblock, string Email, string Gender, int type, DateTime CreatedDate, DateTime CreatedTime)
        //{
        //    this.UserID = UserID;
        //    this.Address = Adrees;
        //    this.Email = Email;
        //    this.Fullname = Fullname;
        //    this.Gender = Gender;
        //    this.Isblock = Isblock;
        //    this.Password = Password;
        //    this.Username = Username;
        //    this.Type = type;
        //    this.CreatedDate = CreatedDate;
        //    this.CreatedTime = CreatedTime;

        //}
        public Users(string Fullname, string Username,string Password, string Phone, string Address, bool Isblock, string Email, string Gender, int type,DateTime CreatedTime)
        {

            this.Address = Address;
            this.Email = Email;
            this.Fullname = Fullname;
            this.Gender = Gender;
            this.Isblock = Isblock;
            this.Password = Password;
            this.Username = Username;
            this.Type = type;
            this.CreatedTime = CreatedTime;
            this.Phone = Phone;

        }

        public Users()
        {
        }

    }
}
