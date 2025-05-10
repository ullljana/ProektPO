using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProektPO.Controller
{
    class Statys
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Statys(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }

        //8
        public DataTable UpdateStatys()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Statys", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddStatys(string Statys)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Statys(Statys) VALUES(@Statys)", connection);
            command.Parameters.AddWithValue("@Statys", Statys);
            command.ExecuteNonQuery();
            connection.Close();
        }



        public void DeleteStatys(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Statys WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


    }
}
