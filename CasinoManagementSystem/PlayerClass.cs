using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System.Data;

namespace CasinoManagementSystem
{
    internal class PlayerClass
    {
        DBconnect connect = new DBconnect();
        // Create a function to add a new students to the database

        public bool insertPlayer(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `player`(`PlyFirstName`, `PlyLastName`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES(@fn, @ln, @bd, @gd, @ph, @adr, @img)",connect.getconnection);

            //@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openConnect();
            if(command.ExecuteNonQuery()==1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        // To get player table
        public DataTable getPlayerlist(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        // Create a function to execute the count query(total, male, female)
        public string exeCount (string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getconnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }
        // To get total player
        public string totalStudent ()
        {
            return exeCount("SELECT COUNT(*) FROM player");
        }

        // To get the male player count
        public string maleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM player WHERE `Gender`= 'Male'");
        }

        // To get the female player count
        public string femaleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM player WHERE `Gender`= 'Female'");
        }

        // Function search for player (First Name, Last Name, Address)
        public DataTable searchPlayer(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `player` WHERE CONCAT(`PlyFirstName`,`PlyLastName`,`Address`) LIKE '%"+ searchdata +"%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Function edit for player
        public bool updatePlayer(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `player` SET `PlyFirstName`=@fn,`PlyLastName`=@ln,`Birthdate`=@bd,`Gender`=@gd,`Phone`=@ph,`Address`=@adr,`Photo`=@img WHERE  `PlyId`= @id", connect.getconnection);


            //@id,@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        // Delete Player
        public bool deletePlayer(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `player` WHERE `plyId`=@id", connect.getconnection);

            //@id
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            connect.openConnect();
            if(command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }


        // Function for any command in playerDB
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
