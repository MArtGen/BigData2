using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;


namespace ElectricData.BL
{
    public interface IDataBaseManager
    {
        List<string> Selection(string c);
        void SaveContent(string content, int id);
        void DeleteContent(int id);
        void ConnectionDB(string servername, string dbname);
    }

    public class DataBaseManager : IDataBaseManager
    {
        public void ConnectionDB(string servername, string dbname)
        {
                string connectionString = @"Data Source=.\" + servername + ";Initial Catalog=" + 
                                        dbname + ";Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                }
        }

        public void DeleteContent(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> Selection (string select_items)
        {
            using (MainDBContext dc = new MainDBContext())
            {
                List<string> nope = new List<string>();
                nope.Add("Nope");
                switch (select_items)
                {
                    case "circuits": var select_circuits = from circuit in dc.circuits select circuit.c_name;
                        return select_circuits.ToList();
                    case "ammeters": var select_ammeters = from ammeter in dc.ammeters select ammeter.ammeters_count;
                        return select_ammeters.ToList().ConvertAll(s => Convert.ToString(s));
                    default: return nope;
                }
            }
        }

        public void SaveContent(string content, int id)
        {
            throw new NotImplementedException();
        }
    }
}
