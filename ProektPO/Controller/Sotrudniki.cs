using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProektPO.Controller
{
    class Sotrydniki
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Sotrydniki(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }

        //8
        public DataTable UpdateSotrydniki()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Sotrydniki", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddSotrydniki(string FIOSotrudnika, string DataRojdeniya, string Pol, string NomerOtdela, string Doljnost, string Zarplata, string Telefon, string Adres)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Sotrydniki(FIOSotrudnika, DataRojdeniya, Pol, NomerOtdela, Doljnost, Zarplata, Telefon, Adres) VALUES(@FIOSotrudnika, @DataRojdeniya, @Pol, @NomerOtdela, @Doljnost, @Zarplata, @Telefon, @Adres)", connection);
            command.Parameters.AddWithValue("@FIOSotrudnika", FIOSotrudnika);
            command.Parameters.AddWithValue("@DataRojdeniya",            DataRojdeniya            );
            command.Parameters.AddWithValue("@Pol",             Pol               );
            command.Parameters.AddWithValue("@NomerOtdela",       NomerOtdela       );
            command.Parameters.AddWithValue("@Doljnost",    Doljnost    );
            command.Parameters.AddWithValue("@Zarplata",           Zarplata             );
            command.Parameters.AddWithValue("@Telefon",         Telefon           );
            command.Parameters.AddWithValue("@Adres",       Adres         );
            command.ExecuteNonQuery();
            connection.Close();
        }

                     

        public void DeleteSotrydniki(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Sotrydniki WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

 
    }
}
