using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppMasGyumolcs
{
    internal class AdatKapcsolat
    {
        MySqlConnection conn;
        MySqlCommand sqlCommand;
        string hibaszoveg = null;

        public AdatKapcsolat(string Server = "localhost", string user = "root", string password = "", string db = "gyumolcsok" )
        {
            conn = new MySqlConnection(kapcsolatstring(Server,user,password,db));
            if (kapcsolatNyit())
            {
                sqlCommand = conn.CreateCommand();
            }
            else
            {
                MessageBox.Show(hibaszoveg);
                hibaszoveg = null;
            }
        }

        public List<Gyumolcs> getAllGyumolcs()
        {
            List<Gyumolcs> list = new List<Gyumolcs>();
            sqlCommand.CommandText= "SELECT `id`,`nev`,`egysegar`,`mennyiseg` FROM `gyumolcsok` WHERE 1";
            if (kapcsolatNyit())
            {
                using(MySqlDataReader dr=sqlCommand.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        Gyumolcs gyumolcs = new Gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                        list.Add(gyumolcs);
                    }                   
                }
                kapcsolatZaras();
            }
            return list;

        }
        private bool kapcsolatNyit()
        {
            //-- A megadott kapcsolat adatok alapján felépíti az adatkérést
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (MySqlException ex)
            {
                hibaszoveg=ex.Message;
               return false;
            }
            return true;
        }
        private bool kapcsolatZaras()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                hibaszoveg = ex.Message;
                return false;
            }
            return true;
        }

        private string kapcsolatstring(string server, string user, string password, string db)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID=user;
            builder.Password = password;
            builder.Database = db;
            return builder.ConnectionString;
        }
    }
}
