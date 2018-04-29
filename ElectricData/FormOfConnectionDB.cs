using System;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace ElectricData
{
    public interface IFormOfConnection
    {
        string Servername { get; set; }
        string DBname { get; set; }
        event EventHandler DBconnect;
        event EventHandler OpenSelect;
    }

    //Форма подключения к базе данных
    public partial class FormOfConnectionDB : MetroForm, IFormOfConnection
    {
        Settings _settings = null;

        public FormOfConnectionDB()
        {
            InitializeComponent();
            _settings = Settings.GetSettings();
            _initControlls();
            Connection_button.Click += Connection_button_Click;
            ExitOfConnection_button.Click += ExitOfConnection_button_Click;
        }

        #region События формы ConnectionDB
        //Обработчик кнопки "Выход"
        private void ExitOfConnection_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Обработчик кнопки подключения к БД
        private void Connection_button_Click(object sender, EventArgs e)
        {
            DBconnect?.Invoke(this, EventArgs.Empty); //Вызов события подключения

            if (Globals.exit_app == false) //Проверка глобальной переменной выхода
            {
                Hide();
                _settings.Server_name = serverName_text.Text;
                _settings.Db_name = nameDB_text.Text;
                _settings.Save(); //Сохранение верных настроек подключения
                OpenSelect?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Application.Restart();
            }
        }
        #endregion

        #region IFormOfConnection
        //Имя сервера
        public string Servername
        {
            get { return serverName_text.Text; }
            set { serverName_text.Text = value; }
        }

        //Имя базы данных
        public string DBname
        {
            get { return nameDB_text.Text; }
            set { nameDB_text.Text = value; }
        }

        //Проброс событий формы подключения к БД
        public event EventHandler DBconnect;
        public event EventHandler OpenSelect;
        #endregion

        #region Методы формы подключения к БД
        // Инициализация поле имени сервера и базы данных
        private void _initControlls()
        {
            serverName_text.Text = _settings.Server_name;
            nameDB_text.Text = _settings.Db_name;
        }
        #endregion
    }
}
