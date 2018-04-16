using System.Linq;
using System.Data.SqlClient;


namespace ElectricData.BL
{
    public interface IDataBaseManager
    {
        string Select_Note(string link_to_link, string source);
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

        public string Select_Note (string link_for_note, string source)
        {
            using (MainDBContext dc = new MainDBContext())
            {
                string[] link;
                if (source == "link")
                {
                    var sel_link = from regist in dc.regists
                                   where regist.PCAM == link_for_note
                                   select regist.link;
                    link = sel_link.ToArray();
                }
                else
                {
                    var sel_extra = from regist in dc.regists
                                    where regist.PCAM == link_for_note
                                    select regist.note;
                    link = sel_extra.ToArray();
                }
                try
                {
                    return link[0];
                }
                catch
                {
                    return "";
                }
            }
        }
    }
}
