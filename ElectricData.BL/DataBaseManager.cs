using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;


namespace ElectricData.BL
{
    public interface IDataBaseManager
    {
        List<string> Selection(string c);
        string Select_Note(string link_to_link, string source);
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
                        return select_ammeters.ToList().ConvertAll(s_am => Convert.ToString(s_am));
                    case "country": var select_country = from country in dc.countries select country.country_name;
                        return select_country.ToList();
                    case "krm": var select_krm = from krm in dc.krms select krm.krm_ind;
                        return select_krm.ToList();
                    case "orders": var select_orders = from order in dc.orders select order.orders_name;
                        return select_orders.ToList().ConvertAll(s_ord => Convert.ToString(s_ord));
                    case "pcam": var select_pcam = from regist in dc.regists select regist.PCAM;
                        return select_pcam.ToList();
                    case "bloks": var select_bloks = from blok in dc.bloks select blok.bloks_name;
                        return select_bloks.ToList();
                    case "conv_u": var select_conv_u = from converters_u in dc.converters_u select converters_u.conv_u;
                        return select_conv_u.ToList();
                    case "conv_i": var select_conv_i = from converters_i in dc.converters_i select converters_i.conv_i;
                        return select_conv_i.ToList();
                    case "counters": var select_counters = from counter in dc.counters select counter.counter_name;
                        return select_counters.ToList();
                    case "inputs": var select_inputs = from input in dc.inputs select input.inputs_count;
                        return select_inputs.ToList().ConvertAll(s_inp => Convert.ToString(s_inp));
                    case "voltmeters": var select_voltmeters = from voltmeter in dc.voltmeters select voltmeter.volt_ind;
                        return select_voltmeters.ToList();
                    default: return nope;
                }
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
                return link[0];
            }
        }

        public void SaveContent(string content, int id)
        {
            throw new NotImplementedException();
        }
    }
}
