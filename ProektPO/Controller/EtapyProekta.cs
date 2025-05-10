using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProektPO.Controller
{
    class EtapyProekta
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public EtapyProekta(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }
 
        public DataTable UpdateEtapyProekta()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM EtapyProekta", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddEtapyProekta(string NazvanieEtapa, string NomerProekta, string SostavGruppu, string StatusEtapa)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO EtapyProekta(NazvanieEtapa, NomerProekta, SostavGruppu, StatusEtapa) VALUES(@NazvanieEtapa, @NomerProekta, @SostavGruppu, @StatusEtapa)", connection);
            command.Parameters.AddWithValue("@NazvanieEtapa", NazvanieEtapa);
            command.Parameters.AddWithValue("@NomerProekta", NomerProekta);
            command.Parameters.AddWithValue("@SostavGruppu", SostavGruppu);
            command.Parameters.AddWithValue("@StatusEtapa", StatusEtapa);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteEtapyProekta(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM EtapyProekta WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
