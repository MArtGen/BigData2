using System;
using MetroFramework.Forms;

namespace ElectricData
{
    public interface IFormOfConnection
    {
        string Servername { get; set; }
        string DBname { get; set; }
        event EventHandler DBconnect;
        event EventHandler ExitApp;
    }

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
        // Инициализация поле имени сервера и базы данных
        private void _initControlls()
        {
            serverName_text.Text = _settings.Server_name;
            nameDB_text.Text = _settings.Db_name;
        }

        #region События формы ConnectionDB
        private void ExitOfConnection_button_Click(object sender, EventArgs e)
        {
            ExitApp?.Invoke(this, EventArgs.Empty);
        }

        private void Connection_button_Click(object sender, EventArgs e)
        {
            _settings.Server_name = serverName_text.Text;
            _settings.Db_name = nameDB_text.Text;
            _settings.Save();

            DBconnect?.Invoke(this, EventArgs.Empty);
            Hide();

            FormOfSelect SelectForm = new FormOfSelect();
            SelectForm.Show();
        }
        #endregion

        #region IFormOfConnection
        public string Servername
        {
            get { return serverName_text.Text; }
            set { serverName_text.Text = value; }
        }
        public string DBname
        {
            get { return nameDB_text.Text; }
            set { nameDB_text.Text = value; }
        }

        public event EventHandler DBconnect;
        public event EventHandler ExitApp;
        #endregion
    }
}
