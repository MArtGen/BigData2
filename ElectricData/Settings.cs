using System.IO;
using System.Xml.Serialization;

namespace ElectricData
{
    //Класс записи настроек в xml
    public class Settings
    {
        public string Server_name { get; set; }
        public string Db_name { get; set; }

        //Получение настроек из файла
        public static Settings GetSettings()
        {
            Settings settings = null;
            string filename = Globals.SettingsFile;

            if (File.Exists(filename)) //поиск файла по имени
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open)) //Считывание данных
                {
                    XmlSerializer xser = new XmlSerializer(typeof(Settings));

                    settings = (Settings)xser.Deserialize(fs);
                    fs.Close();
                }
            }
            else settings = new Settings();

            return settings;
        }

        //Сохранение настроек в файл
        public void Save()
        {
            string filename = Globals.SettingsFile;

            if (File.Exists(filename)) File.Delete(filename); //Перезапись настроек

            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xser = new XmlSerializer(typeof(Settings));
                xser.Serialize(fs, this); //Сериализация настроек
                fs.Close();
            }
        }
    }
}
