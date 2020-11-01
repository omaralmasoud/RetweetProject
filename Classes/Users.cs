using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retweet_Done.Classes
{
    class Users
    {
        private int id;
        private string name;
        private string user;
        private int phone;
        private string pass;
        private int active;
        private string mcod;
        private DateTime dateofend;
        private DateTime dateofreg;
        private string twuser;
        private int price;
        private int ready;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Ready
        {
            get { return ready; }
            set { ready = value; }
        }

        public int Price
        {
            get { return price ; }
            set { price = value; }
        }

        public string Name
        { 
            get { return name; }
            set { name = value; } 
        }

        public string Twuser
        {
            get { return twuser; }
            set { twuser = value; }
        }
        public string User 
        {
            get { return user; }
            set { user = value; } 
        }
           public int Phone 
        {
            get { return phone; }
            set { phone = value; } 
        }
           public string Pass 
        {
            get { return pass; }
            set { pass = value; } 
        }

            public int Active 
        {
            get { return active ; }
            set { active = value; } 
        }
            public string Mcod 
        {
            get { return mcod; }
            set { mcod = value; } 
        }
             public DateTime Dateofend 
        {
            get { return dateofend ; }
            set { dateofend = value; } 
        }
             public DateTime Dateofreg
             {
                 get { return dateofreg; }
                 set { dateofreg = value; }
             }

    }
}
