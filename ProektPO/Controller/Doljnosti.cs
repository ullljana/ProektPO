using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProektPO.Controller
{
    class Doljnosti
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Doljnosti(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }

        public DataTable UpdateDoljnosti()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Doljnosti", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddDoljnosti(string Doljnost)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Doljnosti(Doljnost) VALUES(@Doljnost)", connection);
            command.Parameters.AddWithValue("@Doljnost", Doljnost);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteDoljnosti(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Doljnosti WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
