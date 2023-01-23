using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CasinoManagementSystem
{
    internal class GameClass
    {
        DBconnect connect = new DBconnect();
        // Function to insert game
        public bool insertGame (string gName, int hr, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `game`(`GameName`, `GameHour`, `Description`) VALUES (@gn,@gh,@desc)", connect.getconnection);
            //@gn,@gh,@desc
            command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gName;
            command.Parameters.Add("@gh", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
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

        // Function to get game list
        public DataTable getGame(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Update function for game edit
        public bool updateGame(int id, string gName, int hr, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `game` SET`GameName`=@gn,`GameHour`=@gh,`Description`=@desc WHERE  `GameId`=@id", connect.getconnection);
            //@id,@gn,@gh,@desc
            command.Parameters.Add("@id",MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gName;
            command.Parameters.Add("@gh", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
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

        // Function to delete a course
        // We ony need course id
        public bool deleteGame(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `game` WHERE `GameId`=@id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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

    }
}
