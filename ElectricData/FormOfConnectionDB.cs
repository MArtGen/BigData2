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
            _settings = Settings.GetSettings();
            InitializeComponent();
            Connection_button.Click += Connection_button_Click;
            ExitOfConnection_button.Click += ExitOfConnection_button_Click;
        }

        #region События формы ConnectionDB
        private void ExitOfConnection_button_Click(object sender, EventArgs e)
        {
            ExitApp?.Invoke(this, EventArgs.Empty);
        }

        private void Connection_button_Click(object sender, EventArgs e)
        {
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
