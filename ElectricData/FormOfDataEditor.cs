using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ElectricData
{
    public interface IFormOfDataEditor
    {
        DataGridView TableView { get; }
        event EventHandler TableChange;
        event EventHandler SaveChanges;
        event EventHandler BackToSearch;
    }
    public partial class FormOfDataEditor : MetroForm, IFormOfDataEditor
    {
        public FormOfDataEditor()
        {
            InitializeComponent();
            SaveData_button.Click += SaveData_button_Click;
            ExitOfDataEditor_button.Click += ExitOfDataEditor_button_Click;
        }

        #region События формы DataEditor
        private void ExitOfDataEditor_button_Click(object sender, EventArgs e)
        {
            BackToSearch?.Invoke(this, EventArgs.Empty);
            Hide();
        }

        private void SaveData_button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FormOfDataEditor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.SelectAll". При необходимости она может быть перемещена или удалена.
            this.selectAllTableAdapter.Fill(this.mainDBDataSet.SelectAll);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDBDataSet.SelectAll". При необходимости она может быть перемещена или удалена.
            this.selectAllTableAdapter.Fill(this.mainDBDataSet.SelectAll);
        }
        #endregion

        #region IFormOfDataEditor
        public DataGridView TableView
        {
            get { throw new NotImplementedException(); }
        }

        public event EventHandler BackToSearch;
        public event EventHandler TableChange;
        public event EventHandler SaveChanges;
        #endregion
    }
}
