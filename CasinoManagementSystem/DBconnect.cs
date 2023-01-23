using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CasinoManagementSystem
{
    /*
     * In this class create the connection between application and mysql database
     * We need to install Xampp and mysql connector to this project
     * We need to create the player database 
     */
    internal class DBconnect
    {
        // To create connection
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=playerdb");

        // To get connection
        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }

        // Create a function to Open connection
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        // Create a function to Close connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }

    }
}
