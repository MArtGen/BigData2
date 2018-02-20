using System.IO;
using System.Xml.Serialization;

namespace ElectricData
{
    public class Settings
    {
        public string Server_name { get; set; }
        public string Db_name { get; set; }

        public static Settings GetSettings()
        {
            Settings settings = null;
            string filename = Globals.SettingsFile;

            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(Settings));

                    settings = (Settings)xser.Deserialize(fs);
                    fs.Close();
                }
            }
            else settings = new Settings();

            return settings;
        }
        public void Save()
        {
            string filename = Globals.SettingsFile;

            if (File.Exists(filename)) File.Delete(filename);

            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xser = new XmlSerializer(typeof(Settings));
                xser.Serialize(fs, this);
                fs.Close();
            }
        }
    }
}
