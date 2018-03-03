using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace ElectricData.BL
{
    public interface IDataBaseManager
    {
        string GetNameOfPosition(int id);
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

        public string GetNameOfPosition(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveContent(string content, int id)
        {
            throw new NotImplementedException();
        }
    }
}
