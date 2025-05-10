using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProektPO.Controller
{
    class Proektu
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Proektu(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }

        //8
        public DataTable UpdateProektu()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Proektu", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddProektu(string NazvaniyeProekta, string Zakazchik, string DataNachala, string DlitelnostDney, string SroimostProekta)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Proektu(NazvaniyeProekta, Zakazchik, DataNachala, DlitelnostDney, SroimostProekta) VALUES(@NazvaniyeProekta, @Zakazchik, @DataNachala, @DlitelnostDney, @SroimostProekta)", connection);
            command.Parameters.AddWithValue("@NazvaniyeProekta", NazvaniyeProekta);
            command.Parameters.AddWithValue("@Zakazchik", Zakazchik);
            command.Parameters.AddWithValue("@DataNachala", DataNachala);
            command.Parameters.AddWithValue("@DlitelnostDney", DlitelnostDney);
            command.Parameters.AddWithValue("@SroimostProekta", SroimostProekta);
            command.ExecuteNonQuery();
            connection.Close();
        }



        public void DeleteProektu(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Proektu WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }


    }
}

