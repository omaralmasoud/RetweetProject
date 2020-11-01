using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace Retweet_Done.Classes
{
    class Operations
    {
        private static Conn conn ;


        public static void RegUser(string name, string user, string pass, string phone, DateTime dateofreg)
        {
            conn = new Conn();
            conn.open();

            string addc = "INSERT INTO users (name , phone,datereg,user,pass,temppass) VALUES (@name,@phone,@datereg,@user,@pass,@temppass)";
            MySqlCommand command = new MySqlCommand(addc, conn.maincon);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@datereg", dateofreg);
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            command.Parameters.AddWithValue("@temppass", pass);
            
            try
            {
                conn.open();
                command.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
            finally { conn.close(); }
        }

        public static void OrderRequst(string name, string user, string bankname, int phone, DateTime dateorder, DateTime datesend,string mcod)
        {
            conn = new Conn();
            conn.open();

            string addc = "INSERT INTO subrequst (namesend , phone,datesend,user,bankname,dateorder,mcod) VALUES (@namesend , @phone,@datesend,@user,@bankname,@dateorder,@mcod)";
            MySqlCommand command = new MySqlCommand(addc, conn.maincon);
            command.Parameters.AddWithValue("@namesend", name);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@dateorder", dateorder);
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@bankname", bankname);
            command.Parameters.AddWithValue("@datesend", datesend);
            command.Parameters.AddWithValue("@mcod", mcod);
            try
            {
                conn.open();
                command.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
            finally { conn.close(); }
        }
        public static void RegFreeSub(string mcod, int active, DateTime dateofend)
        {
            conn = new Conn();
            conn.open();

            string addc = "UPDATE users set dateofend=@dateofend,mcod=@mcod,active=@active where user = '" + Home.username + "'";
            MySqlCommand command = new MySqlCommand(addc, conn.maincon);
            
            
            command.Parameters.AddWithValue("@dateofend", dateofend);
            command.Parameters.AddWithValue("@mcod", mcod);
            command.Parameters.AddWithValue("@active", active);
           

            try
            {
                conn.open();
                command.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
            finally { conn.close(); }
        }


        public static void RegUserTw(string user, string twuser, DateTime twdate)
        {
            conn = new Conn();
            conn.open();

            string addc = "INSERT INTO twaccounts (user , twuser,twdate) VALUES (@user,@twuser,@twdate)";
            MySqlCommand command = new MySqlCommand(addc, conn.maincon);
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@twuser", twuser);
            command.Parameters.AddWithValue("@twdate", twdate);
   

            try
            {
                conn.open();
                command.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
            finally { conn.close(); }
        }

        public static List<Users> GetCustomers()
        {
            List<Users> userlists = new List<Users>();
            conn = new Conn();
            try
            {
                conn.open();

                string query = "SELECT users.id ,users.user ,users.ready, users.name, users.phone,users.datereg,users.dateofend,users.active,users.price, twaccounts.twuser,users.mcod from users JOIN twaccounts ON users.user=twaccounts.user where users.user='" + Home.username + "'";

                MySqlCommand cmd = new MySqlCommand(query, conn.maincon);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Users gu = new Users();
                    gu.ID = Convert.ToInt16(dataReader["id"]);
                    gu.Ready = Convert.ToInt16(dataReader["ready"]);
                    gu.Active = Convert.ToInt16(dataReader["active"]);
                    gu.Price = Convert.ToInt32(dataReader["price"]);
                    gu.Name = dataReader["name"].ToString();
                    gu.User = dataReader["user"].ToString();
                   gu.Twuser = dataReader["twuser"].ToString();
                    gu.Phone =Convert.ToInt32( dataReader["phone"]);
                    gu.Dateofreg =(DateTime) dataReader["datereg"];
                    gu.Dateofend = (DateTime)dataReader["dateofend"];
                    gu.Mcod = dataReader["mcod"].ToString();

                    userlists.Add(gu);
                } dataReader.Close();
            }
            catch (Exception e) { e.Message.ToString(); }
            return userlists;

        }

        public static List<Users> GetList()
        {
            List<Users> userlists = new List<Users>();
            conn = new Conn();
            try
            {
                conn.open();               
                string query = "select * from twaccounts where ready=1 order by rand()";
                MySqlCommand cmd = new MySqlCommand(query, conn.maincon);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Users gu = new Users();
                    gu.ID = Convert.ToInt16(dataReader["id"]);
                    
                    gu.Twuser = dataReader["twuser"].ToString();
                    
                    userlists.Add(gu);
                } dataReader.Close();
            }
            catch (Exception e) { e.Message.ToString(); }
            return userlists;

        }


        public static List<SystemOP> GetState()
        {
            List<SystemOP> userlists = new List<SystemOP>();
            conn = new Conn();
            try
            {
                conn.open();
                string query = "select * from ready where id=1";
                MySqlCommand cmd = new MySqlCommand(query, conn.maincon);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    SystemOP gu = new SystemOP();
                    gu.ID = Convert.ToInt16(dataReader["id"]);
                    gu.Ready = Convert.ToInt16(dataReader["ready"]);
                    gu.Noti = dataReader["noti"].ToString();
                    gu.Prioud_end = Convert.ToInt16(dataReader["prioud_end"]);
                    userlists.Add(gu);
                } dataReader.Close();
            }
            catch (Exception e) { e.Message.ToString(); }
            return userlists;

        }
        public static void UpdateUserR(string user, int ready)
        {
            conn = new Conn();
            conn.open();

            string addc = "UPDATE users INNER join twaccounts on users.user=twaccounts.user SET users.ready=@ready,twaccounts.ready=@ready WHERE users.user=@user";
            
            MySqlCommand command = new MySqlCommand(addc, conn.maincon);
            command.Parameters.AddWithValue("@ready", ready);
            command.Parameters.AddWithValue("@user", user);

            try
            {
                conn.open();
                command.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
            finally { conn.close(); }
        }


 
        




    }
}
