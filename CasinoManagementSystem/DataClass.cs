using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoManagementSystem
{
    internal class DataClass
    {
        DBconnect connect = new DBconnect();
        //Function add score
        public bool insertData(int plyid, string gameName, double data, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `data`(`PlayerId`, `GameName`, `Data`, `Description`) VALUES (@plyid,@gn,@data,@desc)", connect.getconnection);
            //@plyid,@gn,@data,@desc
            command.Parameters.Add("@plyid", MySqlDbType.Int32).Value = plyid;
            command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gameName;
            command.Parameters.Add("@data", MySqlDbType.Double).Value = data;
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
        // Fucnction to get list
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

       // Function to check already game data
       public bool checkData(int plyid, string gName)
        {
            DataTable table = getList(new MySqlCommand("SELECT * FROM `data` WHERE `PlayerId`= '"+ plyid +"' AND `GameName`= '"+ gName +"'"));
            if(table.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Function to edit data
        public bool updateData(int plyid, string gmn, double data, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `data` SET `Data`=@data,`Description`=@desc WHERE `PlayerId`=@plyid AND `GameName`=@gmn", connect.getconnection);
            //@plyid,@data,@desc,@gmn
            command.Parameters.Add("@gmn", MySqlDbType.VarChar).Value = gmn;
            command.Parameters.Add("@plyid", MySqlDbType.Int32).Value = plyid;
            command.Parameters.Add("@data", MySqlDbType.Double).Value = data;
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

        // Function to delete data
        public bool deleteData(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `data` WHERE `PlayerId`=@id", connect.getconnection);

            //@id
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
