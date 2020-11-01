using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Retweet_Done
{
    class Conn
    {


         private string connetionString;
        public MySqlConnection maincon;
        public void open()
        {




            connetionString = "server=185.27.133.18;Port=3306;database=itqansol_RetweetDone;uid=itqansol_MRtweet;pwd=NI-(ha4*2Tk9;CharSet=utf8;";
            maincon = new MySqlConnection(connetionString);
            try
            {
                
                maincon.Open();


            }
            catch (Exception e)
            {
                e.Message.ToString(); 
            }

        }
        public void close() { maincon.Close(); }

    }


    
}
