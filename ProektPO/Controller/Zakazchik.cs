using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProektPO.Controller
{
    class Zakazchik
    {
       SqlConnection connection;
       SqlCommand command;
       SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Zakazchik(string Sonn)
        {
            connection = new SqlConnection(Sonn);
            byfferTable = new DataTable();
        }

        //9
        public DataTable UpdateZakazchik()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Zakazchik", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddZakazchik(string FIOZakazchika, string Adres, string Telefon)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Zakazchik(FIOZakazchika, Adres, Telefon) VALUES(@FIOZakazchikaAdres, @Adres, @Telefon)", connection);
            command.Parameters.AddWithValue("@FIOZakazchika", FIOZakazchika);
            command.Parameters.AddWithValue("@Adres", Adres);
            command.Parameters.AddWithValue("@Telefon", Telefon);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteZakazchik(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Zakazchik WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
