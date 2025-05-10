using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProektPO.Controller
{
    class Otdelu
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Otdelu(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }
 
        //6
        public DataTable UpdateOtdelu()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Otdelu", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddOtdelu(string Nazvaniye, string Nachalnik, string Telefone)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Otdelu(Nazvaniye,Nachalnik,Telefone) VALUES(@Nazvaniye,@Nachalnik,@Telefone)", connection);
            command.Parameters.AddWithValue("@Nazvaniye", Nazvaniye);
            command.Parameters.AddWithValue("@Nachalnik", Nachalnik);
            command.Parameters.AddWithValue("@Telefone", Telefone);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteOtdelu(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Otdelu WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
