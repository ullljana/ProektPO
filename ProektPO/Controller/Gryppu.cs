using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProektPO.Controller
{
    class Gryppu
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Gryppu(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }

        public DataTable UpdateGryppu()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Gryppu", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddGryppu(string NachalnikGruppu, string Nazvanie)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Gryppu(NachalnikGruppu, Nazvanie) VALUES(@NachalnikGruppu, @Nazvanie)", connection);
            command.Parameters.AddWithValue("@NachalnikGruppu", NachalnikGruppu);
            command.Parameters.AddWithValue("@Nazvanie", Nazvanie);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteGryppu(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Gryppu WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
