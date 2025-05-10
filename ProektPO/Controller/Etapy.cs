using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProektPO.Controller
{
    class Etapy
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Etapy(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }

        public DataTable UpdateEtapy()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Etapy", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddEtapy(string Nazvaniye)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Etapy(Nazvaniye) VALUES(@Nazvaniye)", connection);
            command.Parameters.AddWithValue("@Nazvaniye", Nazvaniye);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteEtapy(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Etapy WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
