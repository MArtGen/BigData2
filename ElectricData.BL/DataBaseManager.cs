using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;


namespace ElectricData.BL
{
    public interface IDataBaseManager
    {
        List<string> Selection();
        string GetLink(int id);
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

        public string GetLink(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> Selection (string sel)
        {
            using (MainDBContext dc = new MainDBContext())
            {
                IQueryable some_name = sel.AsQueryable();

                var _select = from some_name in dc.circuits
                              select circuit.c_name;
                return _select.ToList();
            }
        }

        public void SaveContent(string content, int id)
        {
            throw new NotImplementedException();
        }
    }
}
