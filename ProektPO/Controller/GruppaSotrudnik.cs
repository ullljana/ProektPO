using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProektPO.Controller
{
    class GruppaSotrudnik
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public GruppaSotrudnik(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }

        public DataTable UpdateGruppaSotrudnik()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM GruppaSotrudnik", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddGruppaSotrudnik(string Gruppa, string Sotrudnik)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO GruppaSotrudnik(Gruppa,Sotrudnik) VALUES(@Gruppa,@Sotrudnik)", connection);
            command.Parameters.AddWithValue("@Gruppa", Gruppa);
            command.Parameters.AddWithValue("@Sotrudnik", Sotrudnik);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteGruppaSotrudnik(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM GruppaSotrudnik WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
